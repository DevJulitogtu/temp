namespace PolicyConnect
{
    partial class PolicyHoldersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PolicyHoldersForm));
            this._objAddEditPolicyHolders = new PolicyConnect.AddEditPolicyHolders();
            this.SuspendLayout();
            // 
            // _objAddEditPolicyHolders
            // 
            this._objAddEditPolicyHolders.Id = 0;
            this._objAddEditPolicyHolders.Location = new System.Drawing.Point(32, 29);
            this._objAddEditPolicyHolders.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this._objAddEditPolicyHolders.Name = "_objAddEditPolicyHolders";
            this._objAddEditPolicyHolders.Operation = PolicyConnect.Domain.CrudOperation.Add;
            this._objAddEditPolicyHolders.Size = new System.Drawing.Size(1280, 1563);
            this._objAddEditPolicyHolders.TabIndex = 0;
            this._objAddEditPolicyHolders.ThisPolicyHolder = null;
            this._objAddEditPolicyHolders.Load += new System.EventHandler(this.objUnboundAddEditPolicyHolders_Load);
            // 
            // PolicyHoldersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1473, 891);
            this.Controls.Add(this._objAddEditPolicyHolders);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "PolicyHoldersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Policy Holders";
            this.ResumeLayout(false);

        }

        #endregion

        private AddEditPolicyHolders _objAddEditPolicyHolders;
    }
}
