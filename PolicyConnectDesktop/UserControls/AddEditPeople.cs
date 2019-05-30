using System;
using System.Drawing;
using System.Windows.Forms;
using Contoso.Apps.Insurance.Data.DTOs;
using PolicyConnect.Domain;
using PolicyConnectDesktop;
using System.Collections.Generic;
using System.ServiceModel.Security;
using PolicyConnectDesktop.DataMethods;
using System.Threading.Tasks;

namespace PolicyConnect
{
    public partial class AddEditPeople : UserControl
    {
        private bool _isFNameValid;
        private bool _isLNameValid;
        private bool _isDobValid;
        public IServiceCalls ServiceCalls { get; set; }

        public int Id { get; set; }

        public Person Person { get; set; }

        public CrudOperation Operation { get; set; }

        public void PopulateEditFields()
        {
            if (Operation == CrudOperation.Update)
            {
                lblTitle.Text = "Edit Existing Person";
                GetPeopleToEdit();
            }
            else
            {
                lblTitle.Text = "Add New Person";
                Person = new Person();
                personBindingSource.DataSource = Person;
            }
        }

        public AddEditPeople()
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

        private void UnboundAddEditPeople_Load(object sender, EventArgs e)
        {
            SetDateFieldsToDefault();
        }

        private void TxtFName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtFName.Text))
            {
                TxtFName.BackColor = Color.White;
                _isFNameValid = true;
            }
            else
            {
                _isFNameValid = false;
            }
        }

        private void TxtLName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtLName.Text))
            {
                TxtLName.BackColor = Color.White;
                _isLNameValid = true;
            }
            else
            {
                _isLNameValid = false;
            }
        }

        private void DtpDob_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DtpDob.Text))
            {
                DtpDob.BackColor = Color.White;
                _isDobValid = true;
            }
            else
            {
                _isDobValid = false;
            }
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            var errors = ValidateEntries();

            if (string.IsNullOrEmpty(errors))
            {
                await AddOrUpdatePeople();
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

        private void DtpDob_ValueChanged(object sender, EventArgs e)
        {
            this.DtpDob.CustomFormat = "MM/dd/yyyy";
        }


        private void SetDateFieldsToDefault()
        {
            this.DtpDob.CustomFormat = " ";
            this.DtpDob.Format = DateTimePickerFormat.Custom;

        }

        private string ValidateEntries()
        {
            var errors = string.Empty;

            // validate
            if (!_isFNameValid)
            {
                errors += "FName is required!\n";
                TxtFName.BackColor = Color.LightPink;
            }

            if (!_isLNameValid)
            {
                errors += "LName is required!\n";
                TxtLName.BackColor = Color.LightPink;
            }

            if (!_isDobValid)
            {
                errors += "Dob is required!\n";
                DtpDob.BackColor = Color.LightPink;
            }

            return errors;
        }

        internal async void GetPeopleToEdit()
        {
            Person = await ServiceCalls.GetPerson(Id);
            personBindingSource.DataSource = Person;
        }

        private async Task AddOrUpdatePeople()
        {
            // Save Person record and retrieve Id.
            Person.Id = await ServiceCalls.SavePerson(Person);
            if (this.Parent.GetType() == typeof(PeopleForm))
            {
                ((PeopleForm)this.Parent).NewPerson = Person;
            }
            
        }
    }
}
