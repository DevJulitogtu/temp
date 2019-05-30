using Contoso.Apps.Insurance.Data.ViewModels;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using PolicyConnect;
using PolicyConnect.Domain;
using PolicyConnectDesktop.Authentication;
using PolicyConnectDesktop.DataMethods;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolicyConnectDesktop
{
    public partial class Main : Form
    {
        private readonly BindingSource _policyHolderBindingSource = new BindingSource();
        private readonly IServiceCalls _serviceCalls;
        readonly IAuthenticationService _AuthenticationService;

        public Main()
        {
            InitializeComponent();
            policyGrid.DataSource = _policyHolderBindingSource;
            policyGrid.AutoGenerateColumns = false;

            // Set the Service Calls to WPF or WebApi:
            if (ApplicationSettings.UseWebApi)
            {
                _AuthenticationService = new AuthenticationService();
                _serviceCalls = new WebApiCalls(_AuthenticationService);
                CheckAuthentication(false);
            }
            else
            {
                _serviceCalls = new WcfCalls();
                CheckAuthentication(true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindPolicyGrid();
        }

        async Task<bool> Authenticate()
        {
            bool success = false;
            try
            {
                // The underlying call behind App.Authenticate() calls the ADAL library, which presents the login UI and awaits success.
                success = await _AuthenticationService.AuthenticateAsync();
            }
            catch (Exception ex)
            {
                if (ex is AdalException && (ex as AdalException).ErrorCode == "authentication_canceled")
                {
                    // Do nothing, just duck the exception. The user just canceled out of the login UI.
                }
                else
                    MessageBox.Show(this, "An unknown login error has occurred. Please try again.", "Login error", MessageBoxButtons.OK);
            }

            return success;
        }

        private async void btnAuth_Click(object sender, EventArgs e)
        {
            if (!ApplicationSettings.UseWebApi)
            {
                ShowLoginForm();
            }
            else
            {
                if (await Authenticate())
                {
                    CheckAuthentication(false);
                }
            }
        }

        private void CheckAuthentication(bool onAppInitialized)
        {
            if (!onAppInitialized)
            {
                AuthenticationMethods.IsAuthenticated = _serviceCalls.CheckAuthentication();
            }
            if (AuthenticationMethods.IsAuthenticated)
            {
                btnAuth.Visible = false;
                btnRefresh.Visible = true;
                lblStatus.Text = $"Logged in as {AuthenticationMethods.Username}";
                menuStrip1.Visible = true;
                BindPolicyGrid();
            }
            else
            {
                btnAuth.Visible = true;
                btnRefresh.Visible = false;
                lblStatus.Text = "You are not logged in. Please log in to begin.";
                menuStrip1.Visible = false;
                //ShowLoginForm();
            }
        }

        private void ShowLoginForm()
        {
            var frmAuth = new LogIn(_serviceCalls);

            frmAuth.FormClosed += FrmAuthOnFormClosed;

            frmAuth.ShowDialog(this);
            frmAuth.Dispose();
        }

        private void FrmAuthOnFormClosed(object sender, FormClosedEventArgs formClosedEventArgs)
        {
            if (((LogIn) sender).Canceled) return;
            CheckAuthentication(false);
        }

        private async void BindPolicyGrid()
        {
            var policyHolders = await _serviceCalls.GetPolicyHolders();
            _policyHolderBindingSource.DataSource = policyHolders;
            policyGrid.Refresh();
        }

        private void policyGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dataItem = (PolicyHolderViewModel)policyGrid.Rows[e.RowIndex].DataBoundItem;
            var frm = new PolicyHoldersForm
            {
                PolicyHolderId = dataItem.Id,
                Operation = CrudOperation.Update,
                ServiceCalls = _serviceCalls
            };

            frm.FormClosed += FrmOnFormClosed;

            frm.ShowDialog(this);
            frm.Dispose();
        }

        private void FrmOnFormClosed(object sender, FormClosedEventArgs formClosedEventArgs)
        {
            if (sender == null || sender.GetType() != typeof(PolicyHoldersForm)) return;
            if (((PolicyHoldersForm) sender).RefreshGrid)
            {
                BindPolicyGrid();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new PolicyHoldersForm {Operation = CrudOperation.Add, ServiceCalls = _serviceCalls};

            frm.FormClosed += FrmOnFormClosed;

            frm.ShowDialog(this);
            frm.Dispose();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}