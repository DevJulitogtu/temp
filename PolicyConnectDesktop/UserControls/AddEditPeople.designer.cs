using System;

namespace PolicyConnect
{
    partial class AddEditPeople
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
            this.LblFName = new System.Windows.Forms.Label();
            this.LblFNameAsterisk = new System.Windows.Forms.Label();
            this.TxtFName = new System.Windows.Forms.TextBox();
            this.LblLName = new System.Windows.Forms.Label();
            this.LblLNameAsterisk = new System.Windows.Forms.Label();
            this.TxtLName = new System.Windows.Forms.TextBox();
            this.LblDob = new System.Windows.Forms.Label();
            this.LblDobAsterisk = new System.Windows.Forms.Label();
            this.DtpDob = new System.Windows.Forms.DateTimePicker();
            this.LblAddress = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.LblAddress2 = new System.Windows.Forms.Label();
            this.TxtAddress2 = new System.Windows.Forms.TextBox();
            this.LblCity = new System.Windows.Forms.Label();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.LblSuburb = new System.Windows.Forms.Label();
            this.TxtSuburb = new System.Windows.Forms.TextBox();
            this.LblPostcode = new System.Windows.Forms.Label();
            this.TxtPostcode = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LblFName
            // 
            this.LblFName.AutoSize = true;
            this.LblFName.Location = new System.Drawing.Point(59, 105);
            this.LblFName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblFName.Name = "LblFName";
            this.LblFName.Size = new System.Drawing.Size(160, 32);
            this.LblFName.TabIndex = 3;
            this.LblFName.Text = "First Name:";
            // 
            // LblFNameAsterisk
            // 
            this.LblFNameAsterisk.AutoSize = true;
            this.LblFNameAsterisk.ForeColor = System.Drawing.Color.Red;
            this.LblFNameAsterisk.Location = new System.Drawing.Point(336, 105);
            this.LblFNameAsterisk.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblFNameAsterisk.Name = "LblFNameAsterisk";
            this.LblFNameAsterisk.Size = new System.Drawing.Size(26, 32);
            this.LblFNameAsterisk.TabIndex = 4;
            this.LblFNameAsterisk.Text = "*";
            // 
            // TxtFName
            // 
            this.TxtFName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "FName", true));
            this.TxtFName.Location = new System.Drawing.Point(373, 98);
            this.TxtFName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TxtFName.Name = "TxtFName";
            this.TxtFName.Size = new System.Drawing.Size(873, 38);
            this.TxtFName.TabIndex = 4;
            this.TxtFName.TextChanged += new System.EventHandler(this.TxtFName_TextChanged);
            // 
            // LblLName
            // 
            this.LblLName.AutoSize = true;
            this.LblLName.Location = new System.Drawing.Point(59, 172);
            this.LblLName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblLName.Name = "LblLName";
            this.LblLName.Size = new System.Drawing.Size(159, 32);
            this.LblLName.TabIndex = 5;
            this.LblLName.Text = "Last Name:";
            // 
            // LblLNameAsterisk
            // 
            this.LblLNameAsterisk.AutoSize = true;
            this.LblLNameAsterisk.ForeColor = System.Drawing.Color.Red;
            this.LblLNameAsterisk.Location = new System.Drawing.Point(336, 172);
            this.LblLNameAsterisk.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblLNameAsterisk.Name = "LblLNameAsterisk";
            this.LblLNameAsterisk.Size = new System.Drawing.Size(26, 32);
            this.LblLNameAsterisk.TabIndex = 6;
            this.LblLNameAsterisk.Text = "*";
            // 
            // TxtLName
            // 
            this.TxtLName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "LName", true));
            this.TxtLName.Location = new System.Drawing.Point(373, 165);
            this.TxtLName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TxtLName.Name = "TxtLName";
            this.TxtLName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtLName.Size = new System.Drawing.Size(873, 38);
            this.TxtLName.TabIndex = 6;
            this.TxtLName.TextChanged += new System.EventHandler(this.TxtLName_TextChanged);
            // 
            // LblDob
            // 
            this.LblDob.AutoSize = true;
            this.LblDob.Location = new System.Drawing.Point(59, 242);
            this.LblDob.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblDob.Name = "LblDob";
            this.LblDob.Size = new System.Drawing.Size(180, 32);
            this.LblDob.TabIndex = 7;
            this.LblDob.Text = "Date of Birth:";
            // 
            // LblDobAsterisk
            // 
            this.LblDobAsterisk.AutoSize = true;
            this.LblDobAsterisk.ForeColor = System.Drawing.Color.Red;
            this.LblDobAsterisk.Location = new System.Drawing.Point(336, 242);
            this.LblDobAsterisk.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblDobAsterisk.Name = "LblDobAsterisk";
            this.LblDobAsterisk.Size = new System.Drawing.Size(26, 32);
            this.LblDobAsterisk.TabIndex = 8;
            this.LblDobAsterisk.Text = "*";
            // 
            // DtpDob
            // 
            this.DtpDob.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personBindingSource, "Dob", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.DtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDob.Location = new System.Drawing.Point(373, 235);
            this.DtpDob.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DtpDob.Name = "DtpDob";
            this.DtpDob.Size = new System.Drawing.Size(873, 38);
            this.DtpDob.TabIndex = 8;
            this.DtpDob.TextChanged += new System.EventHandler(this.DtpDob_TextChanged);
            this.DtpDob.ValueChanged += new System.EventHandler(this.DtpDob_ValueChanged);
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Location = new System.Drawing.Point(59, 309);
            this.LblAddress.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(127, 32);
            this.LblAddress.TabIndex = 9;
            this.LblAddress.Text = "Address:";
            // 
            // TxtAddress
            // 
            this.TxtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Address", true));
            this.TxtAddress.Location = new System.Drawing.Point(373, 301);
            this.TxtAddress.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtAddress.Size = new System.Drawing.Size(873, 138);
            this.TxtAddress.TabIndex = 10;
            // 
            // LblAddress2
            // 
            this.LblAddress2.AutoSize = true;
            this.LblAddress2.Location = new System.Drawing.Point(59, 471);
            this.LblAddress2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblAddress2.Name = "LblAddress2";
            this.LblAddress2.Size = new System.Drawing.Size(150, 32);
            this.LblAddress2.TabIndex = 11;
            this.LblAddress2.Text = "Address 2:";
            // 
            // TxtAddress2
            // 
            this.TxtAddress2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Address2", true));
            this.TxtAddress2.Location = new System.Drawing.Point(373, 464);
            this.TxtAddress2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TxtAddress2.Multiline = true;
            this.TxtAddress2.Name = "TxtAddress2";
            this.TxtAddress2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtAddress2.Size = new System.Drawing.Size(873, 138);
            this.TxtAddress2.TabIndex = 12;
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Location = new System.Drawing.Point(59, 633);
            this.LblCity.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(72, 32);
            this.LblCity.TabIndex = 13;
            this.LblCity.Text = "City:";
            // 
            // TxtCity
            // 
            this.TxtCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "City", true));
            this.TxtCity.Location = new System.Drawing.Point(373, 626);
            this.TxtCity.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtCity.Size = new System.Drawing.Size(873, 38);
            this.TxtCity.TabIndex = 14;
            // 
            // LblSuburb
            // 
            this.LblSuburb.AutoSize = true;
            this.LblSuburb.Location = new System.Drawing.Point(59, 699);
            this.LblSuburb.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblSuburb.Name = "LblSuburb";
            this.LblSuburb.Size = new System.Drawing.Size(115, 32);
            this.LblSuburb.TabIndex = 15;
            this.LblSuburb.Text = "Suburb:";
            // 
            // TxtSuburb
            // 
            this.TxtSuburb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Suburb", true));
            this.TxtSuburb.Location = new System.Drawing.Point(373, 692);
            this.TxtSuburb.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TxtSuburb.Name = "TxtSuburb";
            this.TxtSuburb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtSuburb.Size = new System.Drawing.Size(873, 38);
            this.TxtSuburb.TabIndex = 16;
            // 
            // LblPostcode
            // 
            this.LblPostcode.AutoSize = true;
            this.LblPostcode.Location = new System.Drawing.Point(59, 769);
            this.LblPostcode.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblPostcode.Name = "LblPostcode";
            this.LblPostcode.Size = new System.Drawing.Size(142, 32);
            this.LblPostcode.TabIndex = 17;
            this.LblPostcode.Text = "Postcode:";
            // 
            // TxtPostcode
            // 
            this.TxtPostcode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Postcode", true));
            this.TxtPostcode.Location = new System.Drawing.Point(373, 762);
            this.TxtPostcode.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TxtPostcode.Name = "TxtPostcode";
            this.TxtPostcode.Size = new System.Drawing.Size(336, 38);
            this.TxtPostcode.TabIndex = 18;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(725, 853);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(267, 72);
            this.BtnCancel.TabIndex = 20;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(373, 853);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(336, 72);
            this.BtnSave.TabIndex = 19;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitle.Location = new System.Drawing.Point(57, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(399, 46);
            this.lblTitle.TabIndex = 32;
            this.lblTitle.Text = "Edit Existing Person";
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(Contoso.Apps.Insurance.Data.DTOs.Person);
            // 
            // AddEditPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.LblFName);
            this.Controls.Add(this.LblFNameAsterisk);
            this.Controls.Add(this.TxtFName);
            this.Controls.Add(this.LblLName);
            this.Controls.Add(this.LblLNameAsterisk);
            this.Controls.Add(this.TxtLName);
            this.Controls.Add(this.LblDob);
            this.Controls.Add(this.LblDobAsterisk);
            this.Controls.Add(this.DtpDob);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.LblAddress2);
            this.Controls.Add(this.TxtAddress2);
            this.Controls.Add(this.LblCity);
            this.Controls.Add(this.TxtCity);
            this.Controls.Add(this.LblSuburb);
            this.Controls.Add(this.TxtSuburb);
            this.Controls.Add(this.LblPostcode);
            this.Controls.Add(this.TxtPostcode);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCancel);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "AddEditPeople";
            this.Size = new System.Drawing.Size(1333, 967);
            this.Load += new System.EventHandler(this.UnboundAddEditPeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label LblFName;
        internal System.Windows.Forms.Label LblFNameAsterisk;
        internal System.Windows.Forms.TextBox TxtFName;
        internal System.Windows.Forms.Label LblLName;
        internal System.Windows.Forms.Label LblLNameAsterisk;
        internal System.Windows.Forms.TextBox TxtLName;
        internal System.Windows.Forms.Label LblDob;
        internal System.Windows.Forms.Label LblDobAsterisk;
        internal System.Windows.Forms.DateTimePicker DtpDob;
        internal System.Windows.Forms.Label LblAddress;
        internal System.Windows.Forms.TextBox TxtAddress;
        internal System.Windows.Forms.Label LblAddress2;
        internal System.Windows.Forms.TextBox TxtAddress2;
        internal System.Windows.Forms.Label LblCity;
        internal System.Windows.Forms.TextBox TxtCity;
        internal System.Windows.Forms.Label LblSuburb;
        internal System.Windows.Forms.TextBox TxtSuburb;
        internal System.Windows.Forms.Label LblPostcode;
        internal System.Windows.Forms.TextBox TxtPostcode;
        public System.Windows.Forms.Button BtnSave;
        public System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.BindingSource personBindingSource;
    }
}
