using System;

namespace PolicyConnect
{
    partial class AddEditPolicies
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
            this.LblId = new System.Windows.Forms.Label();
            this.LblIdAsterisk = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblNameAsterisk = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.LblDefaultDeductible = new System.Windows.Forms.Label();
            this.LblDefaultDeductibleAsterisk = new System.Windows.Forms.Label();
            this.MtbDefaultDeductible = new System.Windows.Forms.MaskedTextBox();
            this.LblDefaultOutOfPocketMax = new System.Windows.Forms.Label();
            this.LblDefaultOutOfPocketMaxAsterisk = new System.Windows.Forms.Label();
            this.MtbDefaultOutOfPocketMax = new System.Windows.Forms.MaskedTextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // LblId
            //
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(22, 16);
            this.LblId.Name = ".LblId";
            this.LblId.TabIndex = 1;
            this.LblId.Text = "Id:";
            //
            // LblIdAsterisk
            //
            this.LblIdAsterisk.AutoSize = true;
            this.LblIdAsterisk.ForeColor = System.Drawing.Color.Red;
            this.LblIdAsterisk.Location = new System.Drawing.Point(126, 16);
            this.LblIdAsterisk.Name = ".LblId";
            this.LblIdAsterisk.Size = new System.Drawing.Size(11, 13);
            this.LblIdAsterisk.Text = "*";
            //
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(140, 13);
            this.TxtId.Name = "TxtId";
            this.TxtId.TabIndex = 2;
            this.TxtId.Size = new System.Drawing.Size(330, 20);
            //
            // LblName
            //
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(22, 44);
            this.LblName.Name = ".LblName";
            this.LblName.TabIndex = 3;
            this.LblName.Text = "Name:";
            //
            // LblNameAsterisk
            //
            this.LblNameAsterisk.AutoSize = true;
            this.LblNameAsterisk.ForeColor = System.Drawing.Color.Red;
            this.LblNameAsterisk.Location = new System.Drawing.Point(126, 44);
            this.LblNameAsterisk.Name = ".LblName";
            this.LblNameAsterisk.Size = new System.Drawing.Size(11, 13);
            this.LblNameAsterisk.Text = "*";
            //
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(140, 41);
            this.TxtName.Name = "TxtName";
            this.TxtName.TabIndex = 4;
            this.TxtName.Size = new System.Drawing.Size(330, 20);
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            //
            // LblDescription
            //
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(22, 72);
            this.LblDescription.Name = ".LblDescription";
            this.LblDescription.TabIndex = 5;
            this.LblDescription.Text = "Description:";
            //
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(140, 69);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.TabIndex = 6;
            this.TxtDescription.Multiline = true;
            this.TxtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDescription.Size = new System.Drawing.Size(330, 60);
            //
            // LblDefaultDeductible
            //
            this.LblDefaultDeductible.AutoSize = true;
            this.LblDefaultDeductible.Location = new System.Drawing.Point(22, 140);
            this.LblDefaultDeductible.Name = ".LblDefaultDeductible";
            this.LblDefaultDeductible.TabIndex = 7;
            this.LblDefaultDeductible.Text = "Default Deductible:";
            //
            // LblDefaultDeductibleAsterisk
            //
            this.LblDefaultDeductibleAsterisk.AutoSize = true;
            this.LblDefaultDeductibleAsterisk.ForeColor = System.Drawing.Color.Red;
            this.LblDefaultDeductibleAsterisk.Location = new System.Drawing.Point(126, 140);
            this.LblDefaultDeductibleAsterisk.Name = ".LblDefaultDeductible";
            this.LblDefaultDeductibleAsterisk.Size = new System.Drawing.Size(11, 13);
            this.LblDefaultDeductibleAsterisk.Text = "*";
            //
            // MtbDefaultDeductible
            // 
            this.MtbDefaultDeductible.Location = new System.Drawing.Point(140, 137);
            this.MtbDefaultDeductible.Name = "MtbDefaultDeductible";
            this.MtbDefaultDeductible.TabIndex = 8;
            this.MtbDefaultDeductible.Mask = "999,999,999.00";
            this.MtbDefaultDeductible.ValidatingType = typeof(decimal);
            this.MtbDefaultDeductible.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MtbDefaultDeductible.Size = new System.Drawing.Size(330, 20);
            this.MtbDefaultDeductible.TextChanged += new System.EventHandler(this.MtbDefaultDeductible_TextChanged);
            //
            // LblDefaultOutOfPocketMax
            //
            this.LblDefaultOutOfPocketMax.AutoSize = true;
            this.LblDefaultOutOfPocketMax.Location = new System.Drawing.Point(22, 168);
            this.LblDefaultOutOfPocketMax.Name = ".LblDefaultOutOfPocketMax";
            this.LblDefaultOutOfPocketMax.TabIndex = 9;
            this.LblDefaultOutOfPocketMax.Text = "Default Out Of Poc:";
            //
            // LblDefaultOutOfPocketMaxAsterisk
            //
            this.LblDefaultOutOfPocketMaxAsterisk.AutoSize = true;
            this.LblDefaultOutOfPocketMaxAsterisk.ForeColor = System.Drawing.Color.Red;
            this.LblDefaultOutOfPocketMaxAsterisk.Location = new System.Drawing.Point(126, 168);
            this.LblDefaultOutOfPocketMaxAsterisk.Name = ".LblDefaultOutOfPocketMax";
            this.LblDefaultOutOfPocketMaxAsterisk.Size = new System.Drawing.Size(11, 13);
            this.LblDefaultOutOfPocketMaxAsterisk.Text = "*";
            //
            // MtbDefaultOutOfPocketMax
            // 
            this.MtbDefaultOutOfPocketMax.Location = new System.Drawing.Point(140, 165);
            this.MtbDefaultOutOfPocketMax.Name = "MtbDefaultOutOfPocketMax";
            this.MtbDefaultOutOfPocketMax.TabIndex = 10;
            this.MtbDefaultOutOfPocketMax.Mask = "999,999,999.00";
            this.MtbDefaultOutOfPocketMax.ValidatingType = typeof(decimal);
            this.MtbDefaultOutOfPocketMax.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MtbDefaultOutOfPocketMax.Size = new System.Drawing.Size(330, 20);
            this.MtbDefaultOutOfPocketMax.TextChanged += new System.EventHandler(this.MtbDefaultOutOfPocketMax_TextChanged);
            //
            // BtnSave
            //
            this.BtnSave.Location = new System.Drawing.Point(140, 203);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(126, 30);
            this.BtnSave.TabIndex = 11;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            //
            // BtnCancel
            //
            this.BtnCancel.Location = new System.Drawing.Point(272, 203);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 30);
            this.BtnCancel.TabIndex = 12;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            //
            // AddEditPolicies
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.LblIdAsterisk);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblNameAsterisk);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.LblDefaultDeductible);
            this.Controls.Add(this.LblDefaultDeductibleAsterisk);
            this.Controls.Add(this.MtbDefaultDeductible);
            this.Controls.Add(this.LblDefaultOutOfPocketMax);
            this.Controls.Add(this.LblDefaultOutOfPocketMaxAsterisk);
            this.Controls.Add(this.MtbDefaultOutOfPocketMax);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCancel);
            this.Name = "AddEditPolicies";
            this.Size = new System.Drawing.Size(500, 253);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label LblId;
        internal System.Windows.Forms.Label LblIdAsterisk;
        internal System.Windows.Forms.TextBox TxtId;
        internal System.Windows.Forms.Label LblName;
        internal System.Windows.Forms.Label LblNameAsterisk;
        internal System.Windows.Forms.TextBox TxtName;
        internal System.Windows.Forms.Label LblDescription;
        internal System.Windows.Forms.TextBox TxtDescription;
        internal System.Windows.Forms.Label LblDefaultDeductible;
        internal System.Windows.Forms.Label LblDefaultDeductibleAsterisk;
        internal System.Windows.Forms.MaskedTextBox MtbDefaultDeductible;
        internal System.Windows.Forms.Label LblDefaultOutOfPocketMax;
        internal System.Windows.Forms.Label LblDefaultOutOfPocketMaxAsterisk;
        internal System.Windows.Forms.MaskedTextBox MtbDefaultOutOfPocketMax;
        public System.Windows.Forms.Button BtnSave;
        public System.Windows.Forms.Button BtnCancel;
    }
}
