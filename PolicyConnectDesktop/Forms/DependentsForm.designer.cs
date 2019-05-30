namespace PolicyConnect
{
    partial class DependentsForm
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
            this._objAddEditDependents = new PolicyConnect.AddEditDependents();
            this.SuspendLayout();
            //
            // _objAddEditDependents
            //
            this._objAddEditDependents.Location = new System.Drawing.Point(12, 12);
            this._objAddEditDependents.Name = "_objAddEditDependents";
            this._objAddEditDependents.Operation = PolicyConnect.Domain.CrudOperation.Add;
            this._objAddEditDependents.Size = new System.Drawing.Size(480, 178);
            this._objAddEditDependents.TabIndex = 0;
            this._objAddEditDependents.Load += new System.EventHandler(this.objUnboundAddEditDependents_Load);
            //
            // AddEditDependents
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 208);
            this.MaximizeBox = false;
            this.Controls.Add(this._objAddEditDependents);
            this.Name = "AddEditDependents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Dependents";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AddEditDependents _objAddEditDependents;
    }
}
