namespace PolicyConnect
{
    partial class PoliciesForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._objAddEditPolicies = new PolicyConnect.AddEditPolicies();
            this.SuspendLayout();
            //
            // _objAddEditPolicies
            //
            this._objAddEditPolicies.Location = new System.Drawing.Point(12, 12);
            this._objAddEditPolicies.Name = "_objAddEditPolicies";
            this._objAddEditPolicies.Operation = PolicyConnect.Domain.CrudOperation.Add;
            this._objAddEditPolicies.Size = new System.Drawing.Size(480, 250);
            this._objAddEditPolicies.TabIndex = 0;
            this._objAddEditPolicies.Load += new System.EventHandler(this.objUnboundAddEditPolicies_Load);
            //
            // AddEditPolicies
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 280);
            this.MaximizeBox = false;
            this.Controls.Add(this._objAddEditPolicies);
            this.Name = "AddEditPolicies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Policies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AddEditPolicies _objAddEditPolicies;
    }
}
