using System;
using System.Drawing;
using System.Windows.Forms;
using PolicyConnect.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;
using Contoso.Apps.Insurance.Data.DTOs;
using PolicyConnectDesktop;
using PolicyConnectDesktop.DataMethods;
using static System.String;

namespace PolicyConnect
{
    public partial class AddEditDependents : UserControl
    {
        private bool _isPersonIdValid;
        public IServiceCalls ServiceCalls { get; set; }

        public int Id { get; set; }
        public int PolicyHolderId { get; set; }

        public Dependent ThisDependent { get; set; }

        public CrudOperation Operation { get; set; }

        public List<Person> People = new List<Person>();

        public AddEditDependents()
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
        }

        public void PopulateEditFields()
        {
            if (Operation == CrudOperation.Update)
            {
                lblTitle.Text = "Edit Existing Dependent";
                btnDelete.Visible = true;
            }
            else
            {
                if (PolicyHolderId <= 0)
                {
                    MessageBox.Show(this,
                        "A Policy Holder is not specified. Please only launch this form from the Policy Holder's record.");
                    WindowHelper.CloseParent(this);
                }
                lblTitle.Text = "Add New Dependent";
                ThisDependent = new Dependent();
                btnDelete.Visible = false;
            }

            GetData();
        }

        private void CbxPersonId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxPersonId.SelectedIndex != 0)
            {
                CbxPersonId.BackColor = Color.White;
                _isPersonIdValid = true;
            }
            else
            {
                _isPersonIdValid = false;
            }
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            var errors = ValidateEntries();

            if (IsNullOrEmpty(errors))
            {
                await AddOrUpdateDependents();
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

        private string ValidateEntries()
        {
            var errors = string.Empty;

            // validate
            if (!_isPersonIdValid)
            {
                errors += "Person Id is required!\n";
                CbxPersonId.BackColor = Color.LightPink;
            }

            return errors;
        }

        internal async void GetData()
        {
            ThisDependent = await ServiceCalls.GetDependent(Id);
            People = await ServiceCalls.GetPeople();
            if (Operation == CrudOperation.Add) ThisDependent.PolicyHolderId = PolicyHolderId;
            personBindingSource.DataSource = People;
            dependentBindingSource.DataSource = ThisDependent;
        }

        private async Task AddOrUpdateDependents()
        {
            // Save Dependent record and retrieve Id.
            ThisDependent.Id = await ServiceCalls.SaveDependent(ThisDependent);
            if (this.Parent.GetType() == typeof(DependentsForm))
            {
                ((DependentsForm)this.Parent).RefreshGrid = true;
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
            if (personForm == null || personForm.GetType() != typeof(PeopleForm) || ((PeopleForm)personForm).NewPerson == null) return;
            People = await ServiceCalls.GetPeopleWhoAreNotPolicyHolders();
            var newPerson = ((PeopleForm)personForm).NewPerson;
            ThisDependent.PersonId = newPerson.Id;
            personBindingSource.DataSource = null;
            personBindingSource.DataSource = People;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure you want to remove this dependent?",
                "Remove Dependent?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ServiceCalls.DeleteDependent(Id);
                if (this.Parent.GetType() == typeof(DependentsForm))
                {
                    ((DependentsForm)this.Parent).RefreshGrid = true;
                }
                WindowHelper.CloseParent(this);
            }
        }
    }
}
