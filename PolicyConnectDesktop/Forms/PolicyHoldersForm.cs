using System;
using System.Windows.Forms;
using PolicyConnect.Domain;
using PolicyConnectDesktop;
using PolicyConnectDesktop.DataMethods;

namespace PolicyConnect
{
    public partial class PolicyHoldersForm : Form
    {
        public int PolicyHolderId { get; set; }
        public CrudOperation Operation { get; set; }
        public bool RefreshGrid { get; internal set; }
        public IServiceCalls ServiceCalls { get; set; }

        public PolicyHoldersForm()
        {
            InitializeComponent();
        }

        private void objUnboundAddEditPolicyHolders_Load(object sender, EventArgs e)
        {
            this._objAddEditPolicyHolders.ServiceCalls = ServiceCalls;
            this._objAddEditPolicyHolders.Parent = this;
            this._objAddEditPolicyHolders.Operation = Operation;
            this._objAddEditPolicyHolders.Id = PolicyHolderId;
            this._objAddEditPolicyHolders.PopulateEditFields();
        }
    }
}
