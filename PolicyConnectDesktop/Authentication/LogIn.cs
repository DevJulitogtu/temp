using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PolicyConnectDesktop.DataMethods;

namespace PolicyConnectDesktop.Authentication
{
    public partial class LogIn : Form
    {
        private readonly IServiceCalls _serviceCalls;

        public LogIn(IServiceCalls serviceCalls)
        {
            InitializeComponent();

            //if (ApplicationSettings.UseWebApi)
            //{
            //    _serviceCalls = new WebApiCalls();
            //}
            //else
            //{
            //    _serviceCalls = new WcfCalls();
            //}
            _serviceCalls = serviceCalls;
        }

        public bool Canceled { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            txtUsername.Text = AuthenticationMethods.Username;
            txtPassword.Text = AuthenticationMethods.Password;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Canceled = true;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AuthenticationMethods.Username = txtUsername.Text;
            AuthenticationMethods.Password = txtPassword.Text;

            // Test authentication:
            AuthenticationMethods.IsAuthenticated = _serviceCalls.CheckAuthentication();
            if (AuthenticationMethods.IsAuthenticated)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Authentication failed. Please check your credentials and try again.");
            }
        }
    }
}
