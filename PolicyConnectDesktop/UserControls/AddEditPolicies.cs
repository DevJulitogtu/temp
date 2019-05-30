using System;
using System.Drawing;
using System.Windows.Forms;
using PolicyConnect.Domain;

namespace PolicyConnect
{
    public partial class AddEditPolicies : UserControl
    {
        private bool _isNameValid;
        private bool _isDefaultDeductibleValid;
        private bool _isDefaultOutOfPocketMaxValid;

        public int Id { get; set; }

        public CrudOperation Operation { get; set; }

        public AddEditPolicies()
        {
            InitializeComponent();
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtName.Text))
            {
                TxtName.BackColor = Color.White;
                _isNameValid = true;
            }
            else
            {
                _isNameValid = false;
            }
        }

        private void MtbDefaultDeductible_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(MtbDefaultDeductible.Text))
            {
                MtbDefaultDeductible.BackColor = Color.White;
                _isDefaultDeductibleValid = true;
            }
            else
            {
                _isDefaultDeductibleValid = false;
            }
        }

        private void MtbDefaultOutOfPocketMax_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(MtbDefaultOutOfPocketMax.Text))
            {
                MtbDefaultOutOfPocketMax.BackColor = Color.White;
                _isDefaultOutOfPocketMaxValid = true;
            }
            else
            {
                _isDefaultOutOfPocketMaxValid = false;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string errors = ValidateEntries();

            if (String.IsNullOrEmpty(errors))
            {
                AddOrUpdatePolicies();
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
            string errors = String.Empty;

            // validate
            if (!_isNameValid)
            {
                errors += "Name is required!\n";
                TxtName.BackColor = Color.LightPink;
            }

            if (!_isDefaultDeductibleValid)
            {
                errors += "Default Deductible is required!\n";
                MtbDefaultDeductible.BackColor = Color.LightPink;
            }

            if (!_isDefaultOutOfPocketMaxValid)
            {
                errors += "Default Out Of Pocket Max is required!\n";
                MtbDefaultOutOfPocketMax.BackColor = Color.LightPink;
            }

            return errors;
        }

        internal void GetPoliciesToEdit()
        {
            // place your code here
        }

        private void AddOrUpdatePolicies()
        {
            // place your code here
        }
    }
}
