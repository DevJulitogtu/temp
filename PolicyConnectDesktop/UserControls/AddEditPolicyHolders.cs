using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Security;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contoso.Apps.Insurance.Data.DTOs;
using PolicyConnect.Domain;
using PolicyConnectDesktop;
using PolicyConnectDesktop.DataMethods;

namespace PolicyConnect
{
    public partial class AddEditPolicyHolders : UserControl
    {
        private bool _isPersonIdValid;
        private bool _isUsernameValid;
        private bool _isPolicyIdValid;
        private bool _isPolicyAmountValid;
        private bool _isDeductibleValid;
        private bool _isOutOfPocketMaxValid;
        private bool _isEffectiveDateValid;
        private bool _isExpirationDateValid;
        public IServiceCalls ServiceCalls { get; set; }

        private readonly string _rootPdfPath = ApplicationSettings.RootPdfPath;

        public int Id { get; set; }
        public PolicyHolder ThisPolicyHolder { get; set; }

        public CrudOperation Operation { get; set; }

        public List<Person> People = new List<Person>();
        public List<Policy> Policies = new List<Policy>();
        public List<Dependent> Dependents = new List<Dependent>();

        public AddEditPolicyHolders()
        {
            InitializeComponent();
            lblBaseFilePath.Text = $"File location: {_rootPdfPath}";

            //if (ApplicationSettings.UseWebApi)
            //{
            //    _serviceCalls = new WebApiCalls();
            //}
            //else
            //{
            //    _serviceCalls = new WcfCalls();
            //}
        }

        public void PopulateEditFields()
        {
            if (Operation == CrudOperation.Update)
            {
                lblTitle.Text = "Edit Existing Policy";
                lnkAddDependent.Enabled = true;
                lblDependentAddingDisabled.Visible = false;
                btnDelete.Visible = true;
                lblFilePathForNew.Visible = false;
                TxtPolicyNumber.Enabled = true;
            }
            else
            {
                lblTitle.Text = "Add New Policy";
                ThisPolicyHolder = new PolicyHolder();
                lnkAddDependent.Enabled = false;
                lblDependentAddingDisabled.Visible = true;
                btnDelete.Visible = false;
                lblFilePathForNew.Visible = true;
                TxtPolicyNumber.Enabled = false;
            }

            GetData();
        }

        private void UnboundAddEditPolicyHolders_Load(object sender, EventArgs e)
        {
            SetDateFieldsToDefault();
        }

        private void CbxPersonId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxPersonId.SelectedIndex != -1)
            {
                CbxPersonId.BackColor = Color.White;
                _isPersonIdValid = true;
            }
            else
            {
                _isPersonIdValid = false;
            }
        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtUsername.Text))
            {
                TxtUsername.BackColor = Color.White;
                _isUsernameValid = true;
            }
            else
            {
                _isUsernameValid = false;
            }
        }

        private void CbxPolicyId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxPolicyId.SelectedIndex != 0)
            {
                CbxPolicyId.BackColor = Color.White;
                _isPolicyIdValid = true;
            }
            else
            {
                _isPolicyIdValid = false;
            }
        }

        private void MtbPolicyAmount_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MtbPolicyAmount.Text))
            {
                decimal amount = 0;
                decimal.TryParse(MtbPolicyAmount.Text, out amount);
                if (amount > 0)
                {
                    MtbPolicyAmount.BackColor = Color.White;
                    _isPolicyAmountValid = true;
                }
                else
                {
                    _isPolicyAmountValid = false;
                }
            }
            else
            {
                _isPolicyAmountValid = false;
            }
        }

        private void MtbDeductible_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MtbDeductible.Text))
            {
                decimal amount = 0;
                decimal.TryParse(MtbDeductible.Text, out amount);
                if (amount > 0)
                {
                    MtbDeductible.BackColor = Color.White;
                    _isDeductibleValid = true;
                }
                else
                {
                    _isDeductibleValid = false;
                }
            }
            else
            {
                _isDeductibleValid = false;
            }
        }

        private void MtbOutOfPocketMax_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MtbOutOfPocketMax.Text))
            {
                decimal amount = 0;
                decimal.TryParse(MtbOutOfPocketMax.Text, out amount);
                if (amount > 0)
                {
                    MtbOutOfPocketMax.BackColor = Color.White;
                    _isOutOfPocketMaxValid = true;
                }
                else
                {
                    _isOutOfPocketMaxValid = false;
                }
            }
            else
            {
                _isOutOfPocketMaxValid = false;
            }
        }

        private void DtpEffectiveDate_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DtpEffectiveDate.Text))
            {
                DtpEffectiveDate.BackColor = Color.White;
                _isEffectiveDateValid = true;
            }
            else
            {
                _isEffectiveDateValid = false;
            }
        }

        private void DtpExpirationDate_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DtpExpirationDate.Text))
            {
                DtpExpirationDate.BackColor = Color.White;
                _isExpirationDateValid = true;
            }
            else
            {
                _isExpirationDateValid = false;
            }
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            var errors = ValidateEntries();

            if (string.IsNullOrEmpty(errors))
            {
                await AddOrUpdatePolicyHolders();
                WindowHelper.CloseParent(this);
            }
            else
            {
                MessageBox.Show(errors, "Validation errors");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            WindowHelper.CloseParent(this);
        }

        private void DtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            this.DtpStartDate.CustomFormat = "MM/dd/yyyy";
        }

        private void DtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            this.DtpEndDate.CustomFormat = "MM/dd/yyyy";
        }

        private void DtpEffectiveDate_ValueChanged(object sender, EventArgs e)
        {
            this.DtpEffectiveDate.CustomFormat = "MM/dd/yyyy";
        }

        private void DtpExpirationDate_ValueChanged(object sender, EventArgs e)
        {
            this.DtpExpirationDate.CustomFormat = "MM/dd/yyyy";
        }


        private void SetDateFieldsToDefault()
        {
            this.DtpStartDate.CustomFormat = " ";
            this.DtpStartDate.Format = DateTimePickerFormat.Custom;

            this.DtpEndDate.CustomFormat = " ";
            this.DtpEndDate.Format = DateTimePickerFormat.Custom;

            this.DtpEffectiveDate.CustomFormat = " ";
            this.DtpEffectiveDate.Format = DateTimePickerFormat.Custom;

            this.DtpExpirationDate.CustomFormat = " ";
            this.DtpExpirationDate.Format = DateTimePickerFormat.Custom;

        }

        private string ValidateEntries()
        {
            string errors = String.Empty;

            // validate
            if (!_isPersonIdValid)
            {
                errors += "Person Id is required!\n";
                CbxPersonId.BackColor = Color.LightPink;
            }

            if (!_isUsernameValid)
            {
                errors += "Username is required!\n";
                TxtUsername.BackColor = Color.LightPink;
            }

            if (!_isPolicyIdValid)
            {
                errors += "Policy Id is required!\n";
                CbxPolicyId.BackColor = Color.LightPink;
            }

            if (!_isPolicyAmountValid)
            {
                errors += "Policy Amount is required!\n";
                MtbPolicyAmount.BackColor = Color.LightPink;
            }

            if (!_isDeductibleValid)
            {
                errors += "Deductible is required!\n";
                MtbDeductible.BackColor = Color.LightPink;
            }

            if (!_isOutOfPocketMaxValid)
            {
                errors += "Out Of Pocket Max is required!\n";
                MtbOutOfPocketMax.BackColor = Color.LightPink;
            }

            if (!_isEffectiveDateValid)
            {
                errors += "Effective Date is required!\n";
                DtpEffectiveDate.BackColor = Color.LightPink;
            }

            if (!_isExpirationDateValid)
            {
                errors += "Expiration Date is required!\n";
                DtpExpirationDate.BackColor = Color.LightPink;
            }

            return errors;
        }

        internal async void GetData()
        {
            ThisPolicyHolder = await ServiceCalls.GetPolicyHolder(Id);
            People = await ServiceCalls.GetPeople();
            Policies = await ServiceCalls.GetPolicies();
            Dependents = ThisPolicyHolder.Dependents;

            personBindingSource.DataSource = People;
            policyBindingSource.DataSource = Policies;
            policyHolderBindingSource.DataSource = ThisPolicyHolder;
            dependentBindingSource.DataSource = Dependents;
        }

        private async Task AddOrUpdatePolicyHolders()
        {
            // Save PolicyHolder record and retrieve Id.
            ThisPolicyHolder.Id = await ServiceCalls.SavePolicyHolder(ThisPolicyHolder);

            // If this is a new policy holder, we need to generate the Policy Number
            // and update the file path, if necessary.
            if (Operation == CrudOperation.Add)
            {
                var person = (Person) CbxPersonId.SelectedItem;
                ThisPolicyHolder.PolicyNumber = 
                    Contoso.Apps.Common.PolicyGeneratorMethods.PolicyNumberGenerator(person.LName,
                        ThisPolicyHolder.Id);
                if (string.IsNullOrWhiteSpace(ThisPolicyHolder.FilePath))
                {
                    ThisPolicyHolder.FilePath = @"\" +
                        Contoso.Apps.Common.PolicyGeneratorMethods.PdfFilenameGenerator(person.LName,
                            ThisPolicyHolder.PolicyNumber);
                }
                await ServiceCalls.SavePolicyHolder(ThisPolicyHolder);
            }

            if (this.Parent.GetType() == typeof(PolicyHoldersForm))
            {
                ((PolicyHoldersForm) this.Parent).RefreshGrid = true;
            }
        }

        private async void lnkAddNewPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new PeopleForm
            {
                Operation = CrudOperation.Add,
                ServiceCalls = ServiceCalls
            };

            frm.FormClosed += async (o, args) => await AddNewPersonToList(o);

            frm.ShowDialog(this);
            frm.Dispose();
        }

        private async Task AddNewPersonToList(object personForm)
        {
            if (personForm == null || personForm.GetType() != typeof(PeopleForm) || ((PeopleForm) personForm).NewPerson == null) return;
            People = await ServiceCalls.GetPeople();
            var newPerson = ((PeopleForm) personForm).NewPerson;
            //People.Add(newPerson);
            ThisPolicyHolder.PersonId = newPerson.Id;
            personBindingSource.DataSource = null;
            personBindingSource.DataSource = People;
        }

        private void lnkPdf_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start($@"{_rootPdfPath}\{ThisPolicyHolder.FilePath}");
        }

        private void lnkAddDependent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new DependentsForm
            {
                Operation = CrudOperation.Add,
                PolicyHolderId = Id,
                ServiceCalls = ServiceCalls
            };

            frm.FormClosed += (o, args) => AddNewDependentToList(o);

            frm.ShowDialog(this);
            frm.Dispose();
        }

        private async void AddNewDependentToList(object dependentsForm)
        {
            if (dependentsForm == null || dependentsForm.GetType() != typeof(DependentsForm) || ((DependentsForm)dependentsForm).RefreshGrid == false) return;
            Dependents = await ServiceCalls.GetDependentsByPolicyHolder(ThisPolicyHolder.Id);
            dependentBindingSource.DataSource = null;
            dependentBindingSource.DataSource = Dependents;
        }

        private void grdDependents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataItem = (Dependent)grdDependents.Rows[e.RowIndex].DataBoundItem;
            var frm = new DependentsForm()
            {
                DependentId = dataItem.Id,
                PolicyHolderId = Id,
                Operation = CrudOperation.Update,
                ServiceCalls = ServiceCalls
            };

            frm.FormClosed += (o, args) => AddNewDependentToList(o);

            frm.ShowDialog(this);
            frm.Dispose();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure you want to remove this policy?",
                "Remove Policy?", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            ServiceCalls.DeletePolicyHolder(Id);
            if (this.Parent.GetType() == typeof(PolicyHoldersForm))
            {
                ((PolicyHoldersForm)this.Parent).RefreshGrid = true;
            }
            WindowHelper.CloseParent(this);
        }
    }
}
