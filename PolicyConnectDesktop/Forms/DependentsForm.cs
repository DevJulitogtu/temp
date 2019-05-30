using System;
using System.Windows.Forms;
using PolicyConnect.Domain;
using PolicyConnectDesktop.DataMethods;

namespace PolicyConnect
{
    public partial class DependentsForm : Form
    {
        public int DependentId { get; set; }
        public int PolicyHolderId { get; set; }
        public CrudOperation Operation { get; set; }
        public bool RefreshGrid { get; internal set; }
        public IServiceCalls ServiceCalls { get; set; }

        public DependentsForm()
        {
            InitializeComponent();
        }

        private void objUnboundAddEditDependents_Load(object sender, EventArgs e)
        {
            this._objAddEditDependents.ServiceCalls = ServiceCalls;
            this._objAddEditDependents.Parent = this;
            this._objAddEditDependents.Operation = Operation;
            this._objAddEditDependents.Id = DependentId;
            this._objAddEditDependents.PolicyHolderId = PolicyHolderId;
            this._objAddEditDependents.PopulateEditFields();
        }
    }
}
