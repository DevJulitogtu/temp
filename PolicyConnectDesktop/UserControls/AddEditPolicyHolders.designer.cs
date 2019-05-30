using System;

namespace PolicyConnect
{
    partial class AddEditPolicyHolders
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.policyHolderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LblPersonId = new System.Windows.Forms.Label();
            this.LblPersonIdAsterisk = new System.Windows.Forms.Label();
            this.CbxPersonId = new System.Windows.Forms.ComboBox();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LblActive = new System.Windows.Forms.Label();
            this.LblActiveAsterisk = new System.Windows.Forms.Label();
            this.CbxActive = new System.Windows.Forms.CheckBox();
            this.LblStartDate = new System.Windows.Forms.Label();
            this.DtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.LblEndDate = new System.Windows.Forms.Label();
            this.DtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.LblUsername = new System.Windows.Forms.Label();
            this.LblUsernameAsterisk = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.LblPolicyNumber = new System.Windows.Forms.Label();
            this.TxtPolicyNumber = new System.Windows.Forms.TextBox();
            this.LblPolicyId = new System.Windows.Forms.Label();
            this.LblPolicyIdAsterisk = new System.Windows.Forms.Label();
            this.CbxPolicyId = new System.Windows.Forms.ComboBox();
            this.policyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LblFilePath = new System.Windows.Forms.Label();
            this.TxtFilePath = new System.Windows.Forms.TextBox();
            this.LblPolicyAmount = new System.Windows.Forms.Label();
            this.LblPolicyAmountAsterisk = new System.Windows.Forms.Label();
            this.MtbPolicyAmount = new System.Windows.Forms.MaskedTextBox();
            this.LblDeductible = new System.Windows.Forms.Label();
            this.LblDeductibleAsterisk = new System.Windows.Forms.Label();
            this.MtbDeductible = new System.Windows.Forms.MaskedTextBox();
            this.LblOutOfPocketMax = new System.Windows.Forms.Label();
            this.LblOutOfPocketMaxAsterisk = new System.Windows.Forms.Label();
            this.MtbOutOfPocketMax = new System.Windows.Forms.MaskedTextBox();
            this.LblEffectiveDate = new System.Windows.Forms.Label();
            this.LblEffectiveDateAsterisk = new System.Windows.Forms.Label();
            this.DtpEffectiveDate = new System.Windows.Forms.DateTimePicker();
            this.LblExpirationDate = new System.Windows.Forms.Label();
            this.LblExpirationDateAsterisk = new System.Windows.Forms.Label();
            this.DtpExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lnkAddNewPerson = new System.Windows.Forms.LinkLabel();
            this.lnkPdf = new System.Windows.Forms.LinkLabel();
            this.lblBaseFilePath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkAddDependent = new System.Windows.Forms.LinkLabel();
            this.dependentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grdDependents = new System.Windows.Forms.DataGridView();
            this.personDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblDependentAddingDisabled = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblFilePathForNew = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.policyHolderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDependents)).BeginInit();
            this.SuspendLayout();
            // 
            // policyHolderBindingSource
            // 
            this.policyHolderBindingSource.DataSource = typeof(Contoso.Apps.Insurance.Data.DTOs.PolicyHolder);
            // 
            // LblPersonId
            // 
            this.LblPersonId.AutoSize = true;
            this.LblPersonId.Location = new System.Drawing.Point(59, 105);
            this.LblPersonId.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblPersonId.Name = "LblPersonId";
            this.LblPersonId.Size = new System.Drawing.Size(113, 32);
            this.LblPersonId.TabIndex = 3;
            this.LblPersonId.Text = "Person:";
            // 
            // LblPersonIdAsterisk
            // 
            this.LblPersonIdAsterisk.AutoSize = true;
            this.LblPersonIdAsterisk.ForeColor = System.Drawing.Color.Red;
            this.LblPersonIdAsterisk.Location = new System.Drawing.Point(336, 105);
            this.LblPersonIdAsterisk.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblPersonIdAsterisk.Name = "LblPersonIdAsterisk";
            this.LblPersonIdAsterisk.Size = new System.Drawing.Size(26, 32);
            this.LblPersonIdAsterisk.TabIndex = 4;
            this.LblPersonIdAsterisk.Text = "*";
            // 
            // CbxPersonId
            // 
            this.CbxPersonId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.policyHolderBindingSource, "Person", true));
            this.CbxPersonId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.policyHolderBindingSource, "PersonId", true));
            this.CbxPersonId.DataSource = this.personBindingSource;
            this.CbxPersonId.DisplayMember = "DisplayName";
            this.CbxPersonId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxPersonId.Location = new System.Drawing.Point(373, 98);
            this.CbxPersonId.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CbxPersonId.Name = "CbxPersonId";
            this.CbxPersonId.Size = new System.Drawing.Size(873, 39);
            this.CbxPersonId.TabIndex = 4;
            this.CbxPersonId.ValueMember = "Id";
            this.CbxPersonId.SelectedIndexChanged += new System.EventHandler(this.CbxPersonId_SelectedIndexChanged);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(Contoso.Apps.Insurance.Data.DTOs.Person);
            // 
            // LblActive
            // 
            this.LblActive.AutoSize = true;
            this.LblActive.Location = new System.Drawing.Point(59, 172);
            this.LblActive.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblActive.Name = "LblActive";
            this.LblActive.Size = new System.Drawing.Size(101, 32);
            this.LblActive.TabIndex = 5;
            this.LblActive.Text = "Active:";
            // 
            // LblActiveAsterisk
            // 
            this.LblActiveAsterisk.AutoSize = true;
            this.LblActiveAsterisk.ForeColor = System.Drawing.Color.Red;
            this.LblActiveAsterisk.Location = new System.Drawing.Point(336, 172);
            this.LblActiveAsterisk.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblActiveAsterisk.Name = "LblActiveAsterisk";
            this.LblActiveAsterisk.Size = new System.Drawing.Size(26, 32);
            this.LblActiveAsterisk.TabIndex = 6;
            this.LblActiveAsterisk.Text = "*";
            // 
            // CbxActive
            // 
            this.CbxActive.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.policyHolderBindingSource, "Active", true));
            this.CbxActive.Location = new System.Drawing.Point(373, 165);
            this.CbxActive.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CbxActive.Name = "CbxActive";
            this.CbxActive.Size = new System.Drawing.Size(880, 48);
            this.CbxActive.TabIndex = 6;
            // 
            // LblStartDate
            // 
            this.LblStartDate.AutoSize = true;
            this.LblStartDate.Location = new System.Drawing.Point(59, 238);
            this.LblStartDate.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblStartDate.Name = "LblStartDate";
            this.LblStartDate.Size = new System.Drawing.Size(150, 32);
            this.LblStartDate.TabIndex = 7;
            this.LblStartDate.Text = "Start Date:";
            // 
            // DtpStartDate
            // 
            this.DtpStartDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.policyHolderBindingSource, "StartDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.DtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpStartDate.Location = new System.Drawing.Point(373, 231);
            this.DtpStartDate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DtpStartDate.Name = "DtpStartDate";
            this.DtpStartDate.Size = new System.Drawing.Size(873, 38);
            this.DtpStartDate.TabIndex = 8;
            this.DtpStartDate.ValueChanged += new System.EventHandler(this.DtpStartDate_ValueChanged);
            // 
            // LblEndDate
            // 
            this.LblEndDate.AutoSize = true;
            this.LblEndDate.Location = new System.Drawing.Point(59, 305);
            this.LblEndDate.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblEndDate.Name = "LblEndDate";
            this.LblEndDate.Size = new System.Drawing.Size(141, 32);
            this.LblEndDate.TabIndex = 9;
            this.LblEndDate.Text = "End Date:";
            // 
            // DtpEndDate
            // 
            this.DtpEndDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.policyHolderBindingSource, "EndDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.DtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpEndDate.Location = new System.Drawing.Point(373, 298);
            this.DtpEndDate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DtpEndDate.Name = "DtpEndDate";
            this.DtpEndDate.Size = new System.Drawing.Size(873, 38);
            this.DtpEndDate.TabIndex = 10;
            this.DtpEndDate.ValueChanged += new System.EventHandler(this.DtpEndDate_ValueChanged);
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Location = new System.Drawing.Point(59, 372);
            this.LblUsername.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(153, 32);
            this.LblUsername.TabIndex = 11;
            this.LblUsername.Text = "Username:";
            // 
            // LblUsernameAsterisk
            // 
            this.LblUsernameAsterisk.AutoSize = true;
            this.LblUsernameAsterisk.ForeColor = System.Drawing.Color.Red;
            this.LblUsernameAsterisk.Location = new System.Drawing.Point(336, 372);
            this.LblUsernameAsterisk.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblUsernameAsterisk.Name = "LblUsernameAsterisk";
            this.LblUsernameAsterisk.Size = new System.Drawing.Size(26, 32);
            this.LblUsernameAsterisk.TabIndex = 12;
            this.LblUsernameAsterisk.Text = "*";
            // 
            // TxtUsername
            // 
            this.TxtUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.policyHolderBindingSource, "Username", true));
            this.TxtUsername.Location = new System.Drawing.Point(373, 365);
            this.TxtUsername.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(873, 38);
            this.TxtUsername.TabIndex = 12;
            this.TxtUsername.TextChanged += new System.EventHandler(this.TxtUsername_TextChanged);
            // 
            // LblPolicyNumber
            // 
            this.LblPolicyNumber.AutoSize = true;
            this.LblPolicyNumber.Location = new System.Drawing.Point(59, 439);
            this.LblPolicyNumber.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblPolicyNumber.Name = "LblPolicyNumber";
            this.LblPolicyNumber.Size = new System.Drawing.Size(207, 32);
            this.LblPolicyNumber.TabIndex = 13;
            this.LblPolicyNumber.Text = "Policy Number:";
            // 
            // TxtPolicyNumber
            // 
            this.TxtPolicyNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.policyHolderBindingSource, "PolicyNumber", true));
            this.TxtPolicyNumber.Location = new System.Drawing.Point(373, 432);
            this.TxtPolicyNumber.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TxtPolicyNumber.Name = "TxtPolicyNumber";
            this.TxtPolicyNumber.Size = new System.Drawing.Size(873, 38);
            this.TxtPolicyNumber.TabIndex = 14;
            // 
            // LblPolicyId
            // 
            this.LblPolicyId.AutoSize = true;
            this.LblPolicyId.Location = new System.Drawing.Point(59, 506);
            this.LblPolicyId.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblPolicyId.Name = "LblPolicyId";
            this.LblPolicyId.Size = new System.Drawing.Size(100, 32);
            this.LblPolicyId.TabIndex = 15;
            this.LblPolicyId.Text = "Policy:";
            // 
            // LblPolicyIdAsterisk
            // 
            this.LblPolicyIdAsterisk.AutoSize = true;
            this.LblPolicyIdAsterisk.ForeColor = System.Drawing.Color.Red;
            this.LblPolicyIdAsterisk.Location = new System.Drawing.Point(336, 506);
            this.LblPolicyIdAsterisk.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblPolicyIdAsterisk.Name = "LblPolicyIdAsterisk";
            this.LblPolicyIdAsterisk.Size = new System.Drawing.Size(26, 32);
            this.LblPolicyIdAsterisk.TabIndex = 16;
            this.LblPolicyIdAsterisk.Text = "*";
            // 
            // CbxPolicyId
            // 
            this.CbxPolicyId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.policyHolderBindingSource, "PolicyId", true));
            this.CbxPolicyId.DataSource = this.policyBindingSource;
            this.CbxPolicyId.DisplayMember = "Name";
            this.CbxPolicyId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxPolicyId.Location = new System.Drawing.Point(373, 498);
            this.CbxPolicyId.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CbxPolicyId.Name = "CbxPolicyId";
            this.CbxPolicyId.Size = new System.Drawing.Size(873, 39);
            this.CbxPolicyId.TabIndex = 16;
            this.CbxPolicyId.ValueMember = "Id";
            this.CbxPolicyId.SelectedIndexChanged += new System.EventHandler(this.CbxPolicyId_SelectedIndexChanged);
            // 
            // policyBindingSource
            // 
            this.policyBindingSource.DataSource = typeof(Contoso.Apps.Insurance.Data.DTOs.Policy);
            // 
            // LblFilePath
            // 
            this.LblFilePath.AutoSize = true;
            this.LblFilePath.Location = new System.Drawing.Point(59, 572);
            this.LblFilePath.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblFilePath.Name = "LblFilePath";
            this.LblFilePath.Size = new System.Drawing.Size(136, 32);
            this.LblFilePath.TabIndex = 17;
            this.LblFilePath.Text = "File Path:";
            // 
            // TxtFilePath
            // 
            this.TxtFilePath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.policyHolderBindingSource, "FilePath", true));
            this.TxtFilePath.Location = new System.Drawing.Point(373, 599);
            this.TxtFilePath.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TxtFilePath.Multiline = true;
            this.TxtFilePath.Name = "TxtFilePath";
            this.TxtFilePath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtFilePath.Size = new System.Drawing.Size(873, 65);
            this.TxtFilePath.TabIndex = 18;
            // 
            // LblPolicyAmount
            // 
            this.LblPolicyAmount.AutoSize = true;
            this.LblPolicyAmount.Location = new System.Drawing.Point(59, 734);
            this.LblPolicyAmount.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblPolicyAmount.Name = "LblPolicyAmount";
            this.LblPolicyAmount.Size = new System.Drawing.Size(205, 32);
            this.LblPolicyAmount.TabIndex = 19;
            this.LblPolicyAmount.Text = "Policy Amount:";
            // 
            // LblPolicyAmountAsterisk
            // 
            this.LblPolicyAmountAsterisk.AutoSize = true;
            this.LblPolicyAmountAsterisk.ForeColor = System.Drawing.Color.Red;
            this.LblPolicyAmountAsterisk.Location = new System.Drawing.Point(336, 734);
            this.LblPolicyAmountAsterisk.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblPolicyAmountAsterisk.Name = "LblPolicyAmountAsterisk";
            this.LblPolicyAmountAsterisk.Size = new System.Drawing.Size(26, 32);
            this.LblPolicyAmountAsterisk.TabIndex = 20;
            this.LblPolicyAmountAsterisk.Text = "*";
            // 
            // MtbPolicyAmount
            // 
            this.MtbPolicyAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.policyHolderBindingSource, "PolicyAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.MtbPolicyAmount.Location = new System.Drawing.Point(373, 727);
            this.MtbPolicyAmount.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MtbPolicyAmount.Name = "MtbPolicyAmount";
            this.MtbPolicyAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MtbPolicyAmount.Size = new System.Drawing.Size(873, 38);
            this.MtbPolicyAmount.TabIndex = 20;
            this.MtbPolicyAmount.ValidatingType = typeof(decimal);
            this.MtbPolicyAmount.TextChanged += new System.EventHandler(this.MtbPolicyAmount_TextChanged);
            // 
            // LblDeductible
            // 
            this.LblDeductible.AutoSize = true;
            this.LblDeductible.Location = new System.Drawing.Point(59, 801);
            this.LblDeductible.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblDeductible.Name = "LblDeductible";
            this.LblDeductible.Size = new System.Drawing.Size(159, 32);
            this.LblDeductible.TabIndex = 21;
            this.LblDeductible.Text = "Deductible:";
            // 
            // LblDeductibleAsterisk
            // 
            this.LblDeductibleAsterisk.AutoSize = true;
            this.LblDeductibleAsterisk.ForeColor = System.Drawing.Color.Red;
            this.LblDeductibleAsterisk.Location = new System.Drawing.Point(336, 801);
            this.LblDeductibleAsterisk.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblDeductibleAsterisk.Name = "LblDeductibleAsterisk";
            this.LblDeductibleAsterisk.Size = new System.Drawing.Size(26, 32);
            this.LblDeductibleAsterisk.TabIndex = 22;
            this.LblDeductibleAsterisk.Text = "*";
            // 
            // MtbDeductible
            // 
            this.MtbDeductible.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.policyHolderBindingSource, "Deductible", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.MtbDeductible.Location = new System.Drawing.Point(373, 794);
            this.MtbDeductible.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MtbDeductible.Name = "MtbDeductible";
            this.MtbDeductible.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MtbDeductible.Size = new System.Drawing.Size(873, 38);
            this.MtbDeductible.TabIndex = 22;
            this.MtbDeductible.ValidatingType = typeof(decimal);
            this.MtbDeductible.TextChanged += new System.EventHandler(this.MtbDeductible_TextChanged);
            // 
            // LblOutOfPocketMax
            // 
            this.LblOutOfPocketMax.AutoSize = true;
            this.LblOutOfPocketMax.Location = new System.Drawing.Point(59, 868);
            this.LblOutOfPocketMax.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblOutOfPocketMax.Name = "LblOutOfPocketMax";
            this.LblOutOfPocketMax.Size = new System.Drawing.Size(260, 32);
            this.LblOutOfPocketMax.TabIndex = 23;
            this.LblOutOfPocketMax.Text = "Out Of Pocket Max:";
            // 
            // LblOutOfPocketMaxAsterisk
            // 
            this.LblOutOfPocketMaxAsterisk.AutoSize = true;
            this.LblOutOfPocketMaxAsterisk.ForeColor = System.Drawing.Color.Red;
            this.LblOutOfPocketMaxAsterisk.Location = new System.Drawing.Point(336, 868);
            this.LblOutOfPocketMaxAsterisk.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblOutOfPocketMaxAsterisk.Name = "LblOutOfPocketMaxAsterisk";
            this.LblOutOfPocketMaxAsterisk.Size = new System.Drawing.Size(26, 32);
            this.LblOutOfPocketMaxAsterisk.TabIndex = 24;
            this.LblOutOfPocketMaxAsterisk.Text = "*";
            // 
            // MtbOutOfPocketMax
            // 
            this.MtbOutOfPocketMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.policyHolderBindingSource, "OutOfPocketMax", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.MtbOutOfPocketMax.Location = new System.Drawing.Point(373, 861);
            this.MtbOutOfPocketMax.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MtbOutOfPocketMax.Name = "MtbOutOfPocketMax";
            this.MtbOutOfPocketMax.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MtbOutOfPocketMax.Size = new System.Drawing.Size(873, 38);
            this.MtbOutOfPocketMax.TabIndex = 24;
            this.MtbOutOfPocketMax.ValidatingType = typeof(decimal);
            this.MtbOutOfPocketMax.TextChanged += new System.EventHandler(this.MtbOutOfPocketMax_TextChanged);
            // 
            // LblEffectiveDate
            // 
            this.LblEffectiveDate.AutoSize = true;
            this.LblEffectiveDate.Location = new System.Drawing.Point(59, 935);
            this.LblEffectiveDate.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblEffectiveDate.Name = "LblEffectiveDate";
            this.LblEffectiveDate.Size = new System.Drawing.Size(200, 32);
            this.LblEffectiveDate.TabIndex = 25;
            this.LblEffectiveDate.Text = "Effective Date:";
            // 
            // LblEffectiveDateAsterisk
            // 
            this.LblEffectiveDateAsterisk.AutoSize = true;
            this.LblEffectiveDateAsterisk.ForeColor = System.Drawing.Color.Red;
            this.LblEffectiveDateAsterisk.Location = new System.Drawing.Point(336, 935);
            this.LblEffectiveDateAsterisk.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblEffectiveDateAsterisk.Name = "LblEffectiveDateAsterisk";
            this.LblEffectiveDateAsterisk.Size = new System.Drawing.Size(26, 32);
            this.LblEffectiveDateAsterisk.TabIndex = 26;
            this.LblEffectiveDateAsterisk.Text = "*";
            // 
            // DtpEffectiveDate
            // 
            this.DtpEffectiveDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.policyHolderBindingSource, "EffectiveDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.DtpEffectiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpEffectiveDate.Location = new System.Drawing.Point(373, 928);
            this.DtpEffectiveDate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DtpEffectiveDate.Name = "DtpEffectiveDate";
            this.DtpEffectiveDate.Size = new System.Drawing.Size(873, 38);
            this.DtpEffectiveDate.TabIndex = 26;
            this.DtpEffectiveDate.TextChanged += new System.EventHandler(this.DtpEffectiveDate_TextChanged);
            this.DtpEffectiveDate.ValueChanged += new System.EventHandler(this.DtpEffectiveDate_ValueChanged);
            // 
            // LblExpirationDate
            // 
            this.LblExpirationDate.AutoSize = true;
            this.LblExpirationDate.Location = new System.Drawing.Point(59, 1002);
            this.LblExpirationDate.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblExpirationDate.Name = "LblExpirationDate";
            this.LblExpirationDate.Size = new System.Drawing.Size(218, 32);
            this.LblExpirationDate.TabIndex = 27;
            this.LblExpirationDate.Text = "Expiration Date:";
            // 
            // LblExpirationDateAsterisk
            // 
            this.LblExpirationDateAsterisk.AutoSize = true;
            this.LblExpirationDateAsterisk.ForeColor = System.Drawing.Color.Red;
            this.LblExpirationDateAsterisk.Location = new System.Drawing.Point(336, 1002);
            this.LblExpirationDateAsterisk.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblExpirationDateAsterisk.Name = "LblExpirationDateAsterisk";
            this.LblExpirationDateAsterisk.Size = new System.Drawing.Size(26, 32);
            this.LblExpirationDateAsterisk.TabIndex = 28;
            this.LblExpirationDateAsterisk.Text = "*";
            // 
            // DtpExpirationDate
            // 
            this.DtpExpirationDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.policyHolderBindingSource, "ExpirationDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.DtpExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpExpirationDate.Location = new System.Drawing.Point(373, 994);
            this.DtpExpirationDate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DtpExpirationDate.Name = "DtpExpirationDate";
            this.DtpExpirationDate.Size = new System.Drawing.Size(873, 38);
            this.DtpExpirationDate.TabIndex = 28;
            this.DtpExpirationDate.TextChanged += new System.EventHandler(this.DtpExpirationDate_TextChanged);
            this.DtpExpirationDate.ValueChanged += new System.EventHandler(this.DtpExpirationDate_ValueChanged);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(986, 1439);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(267, 72);
            this.BtnCancel.TabIndex = 30;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(634, 1439);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(336, 72);
            this.BtnSave.TabIndex = 29;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitle.Location = new System.Drawing.Point(59, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(381, 46);
            this.lblTitle.TabIndex = 31;
            this.lblTitle.Text = "Edit Existing Policy";
            // 
            // lnkAddNewPerson
            // 
            this.lnkAddNewPerson.AutoSize = true;
            this.lnkAddNewPerson.Location = new System.Drawing.Point(1010, 148);
            this.lnkAddNewPerson.Name = "lnkAddNewPerson";
            this.lnkAddNewPerson.Size = new System.Drawing.Size(243, 32);
            this.lnkAddNewPerson.TabIndex = 32;
            this.lnkAddNewPerson.TabStop = true;
            this.lnkAddNewPerson.Text = "Add new person...";
            this.lnkAddNewPerson.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddNewPerson_LinkClicked);
            // 
            // lnkPdf
            // 
            this.lnkPdf.AutoSize = true;
            this.lnkPdf.Location = new System.Drawing.Point(373, 675);
            this.lnkPdf.Name = "lnkPdf";
            this.lnkPdf.Size = new System.Drawing.Size(216, 32);
            this.lnkPdf.TabIndex = 33;
            this.lnkPdf.TabStop = true;
            this.lnkPdf.Text = "Download Pdf...";
            this.lnkPdf.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPdf_LinkClicked);
            // 
            // lblBaseFilePath
            // 
            this.lblBaseFilePath.AutoSize = true;
            this.lblBaseFilePath.Location = new System.Drawing.Point(373, 560);
            this.lblBaseFilePath.Name = "lblBaseFilePath";
            this.lblBaseFilePath.Size = new System.Drawing.Size(184, 32);
            this.lblBaseFilePath.TabIndex = 34;
            this.lblBaseFilePath.Text = "File location: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 1119);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 32);
            this.label1.TabIndex = 36;
            this.label1.Text = "Dependents:";
            // 
            // lnkAddDependent
            // 
            this.lnkAddDependent.AutoSize = true;
            this.lnkAddDependent.Location = new System.Drawing.Point(59, 1195);
            this.lnkAddDependent.Name = "lnkAddDependent";
            this.lnkAddDependent.Size = new System.Drawing.Size(233, 32);
            this.lnkAddDependent.TabIndex = 37;
            this.lnkAddDependent.TabStop = true;
            this.lnkAddDependent.Text = "Add dependent...";
            this.lnkAddDependent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddDependent_LinkClicked);
            // 
            // dependentBindingSource
            // 
            this.dependentBindingSource.DataSource = typeof(Contoso.Apps.Insurance.Data.DTOs.Dependent);
            // 
            // grdDependents
            // 
            this.grdDependents.AutoGenerateColumns = false;
            this.grdDependents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdDependents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDependents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn});
            this.grdDependents.DataSource = this.dependentBindingSource;
            this.grdDependents.Location = new System.Drawing.Point(373, 1108);
            this.grdDependents.Name = "grdDependents";
            this.grdDependents.RowTemplate.Height = 40;
            this.grdDependents.Size = new System.Drawing.Size(873, 289);
            this.grdDependents.TabIndex = 38;
            this.grdDependents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDependents_CellDoubleClick);
            // 
            // personDataGridViewTextBoxColumn
            // 
            this.personDataGridViewTextBoxColumn.DataPropertyName = "Person";
            this.personDataGridViewTextBoxColumn.HeaderText = "Person";
            this.personDataGridViewTextBoxColumn.Name = "personDataGridViewTextBoxColumn";
            this.personDataGridViewTextBoxColumn.ReadOnly = true;
            this.personDataGridViewTextBoxColumn.Width = 159;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "Active";
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activeDataGridViewCheckBoxColumn.Width = 99;
            // 
            // lblDependentAddingDisabled
            // 
            this.lblDependentAddingDisabled.AutoSize = true;
            this.lblDependentAddingDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDependentAddingDisabled.Location = new System.Drawing.Point(59, 1250);
            this.lblDependentAddingDisabled.Name = "lblDependentAddingDisabled";
            this.lblDependentAddingDisabled.Size = new System.Drawing.Size(313, 128);
            this.lblDependentAddingDisabled.TabIndex = 39;
            this.lblDependentAddingDisabled.Text = "(Since this is a new\r\npolicy, you cannot \r\nadd any dependents \r\nuntil you save th" +
    "is form)";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightPink;
            this.btnDelete.Location = new System.Drawing.Point(65, 1439);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(259, 72);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Remove Policy";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblFilePathForNew
            // 
            this.lblFilePathForNew.AutoSize = true;
            this.lblFilePathForNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilePathForNew.Location = new System.Drawing.Point(61, 609);
            this.lblFilePathForNew.Name = "lblFilePathForNew";
            this.lblFilePathForNew.Size = new System.Drawing.Size(219, 64);
            this.lblFilePathForNew.TabIndex = 41;
            this.lblFilePathForNew.Text = "(Auto generated\r\nif left blank)";
            // 
            // AddEditPolicyHolders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFilePathForNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblDependentAddingDisabled);
            this.Controls.Add(this.grdDependents);
            this.Controls.Add(this.lnkAddDependent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBaseFilePath);
            this.Controls.Add(this.lnkPdf);
            this.Controls.Add(this.lnkAddNewPerson);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.LblPersonId);
            this.Controls.Add(this.LblPersonIdAsterisk);
            this.Controls.Add(this.CbxPersonId);
            this.Controls.Add(this.LblActive);
            this.Controls.Add(this.LblActiveAsterisk);
            this.Controls.Add(this.CbxActive);
            this.Controls.Add(this.LblStartDate);
            this.Controls.Add(this.DtpStartDate);
            this.Controls.Add(this.LblEndDate);
            this.Controls.Add(this.DtpEndDate);
            this.Controls.Add(this.LblUsername);
            this.Controls.Add(this.LblUsernameAsterisk);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.LblPolicyNumber);
            this.Controls.Add(this.TxtPolicyNumber);
            this.Controls.Add(this.LblPolicyId);
            this.Controls.Add(this.LblPolicyIdAsterisk);
            this.Controls.Add(this.CbxPolicyId);
            this.Controls.Add(this.LblFilePath);
            this.Controls.Add(this.TxtFilePath);
            this.Controls.Add(this.LblPolicyAmount);
            this.Controls.Add(this.LblPolicyAmountAsterisk);
            this.Controls.Add(this.MtbPolicyAmount);
            this.Controls.Add(this.LblDeductible);
            this.Controls.Add(this.LblDeductibleAsterisk);
            this.Controls.Add(this.MtbDeductible);
            this.Controls.Add(this.LblOutOfPocketMax);
            this.Controls.Add(this.LblOutOfPocketMaxAsterisk);
            this.Controls.Add(this.MtbOutOfPocketMax);
            this.Controls.Add(this.LblEffectiveDate);
            this.Controls.Add(this.LblEffectiveDateAsterisk);
            this.Controls.Add(this.DtpEffectiveDate);
            this.Controls.Add(this.LblExpirationDate);
            this.Controls.Add(this.LblExpirationDateAsterisk);
            this.Controls.Add(this.DtpExpirationDate);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCancel);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "AddEditPolicyHolders";
            this.Size = new System.Drawing.Size(1333, 1536);
            this.Load += new System.EventHandler(this.UnboundAddEditPolicyHolders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.policyHolderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDependents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label LblPersonId;
        internal System.Windows.Forms.Label LblPersonIdAsterisk;
        internal System.Windows.Forms.ComboBox CbxPersonId;
        internal System.Windows.Forms.Label LblActive;
        internal System.Windows.Forms.Label LblActiveAsterisk;
        internal System.Windows.Forms.CheckBox CbxActive;
        internal System.Windows.Forms.Label LblStartDate;
        internal System.Windows.Forms.DateTimePicker DtpStartDate;
        internal System.Windows.Forms.Label LblEndDate;
        internal System.Windows.Forms.DateTimePicker DtpEndDate;
        internal System.Windows.Forms.Label LblUsername;
        internal System.Windows.Forms.Label LblUsernameAsterisk;
        internal System.Windows.Forms.TextBox TxtUsername;
        internal System.Windows.Forms.Label LblPolicyNumber;
        internal System.Windows.Forms.TextBox TxtPolicyNumber;
        internal System.Windows.Forms.Label LblPolicyId;
        internal System.Windows.Forms.Label LblPolicyIdAsterisk;
        internal System.Windows.Forms.ComboBox CbxPolicyId;
        internal System.Windows.Forms.Label LblFilePath;
        internal System.Windows.Forms.TextBox TxtFilePath;
        internal System.Windows.Forms.Label LblPolicyAmount;
        internal System.Windows.Forms.Label LblPolicyAmountAsterisk;
        internal System.Windows.Forms.MaskedTextBox MtbPolicyAmount;
        internal System.Windows.Forms.Label LblDeductible;
        internal System.Windows.Forms.Label LblDeductibleAsterisk;
        internal System.Windows.Forms.MaskedTextBox MtbDeductible;
        internal System.Windows.Forms.Label LblOutOfPocketMax;
        internal System.Windows.Forms.Label LblOutOfPocketMaxAsterisk;
        internal System.Windows.Forms.MaskedTextBox MtbOutOfPocketMax;
        internal System.Windows.Forms.Label LblEffectiveDate;
        internal System.Windows.Forms.Label LblEffectiveDateAsterisk;
        internal System.Windows.Forms.DateTimePicker DtpEffectiveDate;
        internal System.Windows.Forms.Label LblExpirationDate;
        internal System.Windows.Forms.Label LblExpirationDateAsterisk;
        internal System.Windows.Forms.DateTimePicker DtpExpirationDate;
        public System.Windows.Forms.Button BtnSave;
        public System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.BindingSource policyHolderBindingSource;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.BindingSource policyBindingSource;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.LinkLabel lnkAddNewPerson;
        private System.Windows.Forms.LinkLabel lnkPdf;
        private System.Windows.Forms.Label lblBaseFilePath;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkAddDependent;
        private System.Windows.Forms.BindingSource dependentBindingSource;
        private System.Windows.Forms.DataGridView grdDependents;
        private System.Windows.Forms.DataGridViewTextBoxColumn personDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label lblDependentAddingDisabled;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblFilePathForNew;
    }
}
