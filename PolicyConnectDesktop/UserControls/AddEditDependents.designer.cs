using System;

namespace PolicyConnect
{
    partial class AddEditDependents
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
            this.LblPersonId = new System.Windows.Forms.Label();
            this.LblPersonIdAsterisk = new System.Windows.Forms.Label();
            this.CbxPersonId = new System.Windows.Forms.ComboBox();
            this.dependentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LblActive = new System.Windows.Forms.Label();
            this.LblActiveAsterisk = new System.Windows.Forms.Label();
            this.CbxActive = new System.Windows.Forms.CheckBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.lnkAddNewPerson = new System.Windows.Forms.LinkLabel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dependentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.CbxPersonId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dependentBindingSource, "PersonId", true));
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
            // dependentBindingSource
            // 
            this.dependentBindingSource.DataSource = typeof(Contoso.Apps.Insurance.Data.DTOs.Dependent);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(Contoso.Apps.Insurance.Data.DTOs.Person);
            // 
            // LblActive
            // 
            this.LblActive.AutoSize = true;
            this.LblActive.Location = new System.Drawing.Point(59, 204);
            this.LblActive.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblActive.Name = "LblActive";
            this.LblActive.Size = new System.Drawing.Size(101, 32);
            this.LblActive.TabIndex = 7;
            this.LblActive.Text = "Active:";
            // 
            // LblActiveAsterisk
            // 
            this.LblActiveAsterisk.AutoSize = true;
            this.LblActiveAsterisk.ForeColor = System.Drawing.Color.Red;
            this.LblActiveAsterisk.Location = new System.Drawing.Point(336, 204);
            this.LblActiveAsterisk.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LblActiveAsterisk.Name = "LblActiveAsterisk";
            this.LblActiveAsterisk.Size = new System.Drawing.Size(26, 32);
            this.LblActiveAsterisk.TabIndex = 8;
            this.LblActiveAsterisk.Text = "*";
            // 
            // CbxActive
            // 
            this.CbxActive.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.dependentBindingSource, "Active", true));
            this.CbxActive.Location = new System.Drawing.Point(373, 197);
            this.CbxActive.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CbxActive.Name = "CbxActive";
            this.CbxActive.Size = new System.Drawing.Size(880, 48);
            this.CbxActive.TabIndex = 8;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(979, 322);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(267, 72);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(627, 322);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(336, 72);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lnkAddNewPerson
            // 
            this.lnkAddNewPerson.AutoSize = true;
            this.lnkAddNewPerson.Location = new System.Drawing.Point(1003, 158);
            this.lnkAddNewPerson.Name = "lnkAddNewPerson";
            this.lnkAddNewPerson.Size = new System.Drawing.Size(243, 32);
            this.lnkAddNewPerson.TabIndex = 33;
            this.lnkAddNewPerson.TabStop = true;
            this.lnkAddNewPerson.Text = "Add new person...";
            this.lnkAddNewPerson.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddNewPerson_LinkClicked);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitle.Location = new System.Drawing.Point(57, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(469, 46);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.Text = "Edit Existing Dependent";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightPink;
            this.btnDelete.Location = new System.Drawing.Point(51, 322);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelete.Size = new System.Drawing.Size(175, 72);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Remove";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AddEditDependents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lnkAddNewPerson);
            this.Controls.Add(this.LblPersonId);
            this.Controls.Add(this.LblPersonIdAsterisk);
            this.Controls.Add(this.CbxPersonId);
            this.Controls.Add(this.LblActive);
            this.Controls.Add(this.LblActiveAsterisk);
            this.Controls.Add(this.CbxActive);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCancel);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "AddEditDependents";
            this.Size = new System.Drawing.Size(1333, 441);
            ((System.ComponentModel.ISupportInitialize)(this.dependentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
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
        public System.Windows.Forms.Button BtnSave;
        public System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.LinkLabel lnkAddNewPerson;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.BindingSource dependentBindingSource;
        private System.Windows.Forms.Button btnDelete;
    }
}
