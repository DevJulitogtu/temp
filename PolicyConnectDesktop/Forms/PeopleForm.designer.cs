namespace PolicyConnect
{
    partial class PeopleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeopleForm));
            this._objAddEditPeople = new PolicyConnect.AddEditPeople();
            this.SuspendLayout();
            // 
            // _objAddEditPeople
            // 
            this._objAddEditPeople.Id = 0;
            this._objAddEditPeople.Location = new System.Drawing.Point(32, 29);
            this._objAddEditPeople.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this._objAddEditPeople.Name = "_objAddEditPeople";
            this._objAddEditPeople.Operation = PolicyConnect.Domain.CrudOperation.Add;
            this._objAddEditPeople.Person = null;
            this._objAddEditPeople.Size = new System.Drawing.Size(1280, 1283);
            this._objAddEditPeople.TabIndex = 0;
            this._objAddEditPeople.Load += new System.EventHandler(this.objUnboundAddEditPeople_Load);
            // 
            // PeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1387, 1085);
            this.Controls.Add(this._objAddEditPeople);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "PeopleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update People";
            this.ResumeLayout(false);

        }

        #endregion

        private AddEditPeople _objAddEditPeople;
    }
}
