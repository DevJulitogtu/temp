using System;
using System.Windows.Forms;
using PolicyConnect.Domain;
using PolicyConnectDesktop;
using Contoso.Apps.Insurance.Data.DTOs;
using PolicyConnectDesktop.DataMethods;

namespace PolicyConnect
{
    public partial class PeopleForm : Form
    {
        public int PersonId { get; set; }
        public CrudOperation Operation { get; set; }
        public Person NewPerson { get; set; }
        public IServiceCalls ServiceCalls { get; set; }

        public PeopleForm()
        {
            InitializeComponent();
        }

        private void objUnboundAddEditPeople_Load(object sender, EventArgs e)
        {
            this._objAddEditPeople.ServiceCalls = ServiceCalls;
            this._objAddEditPeople.Parent = this;
            this._objAddEditPeople.Operation = Operation;
            this._objAddEditPeople.Id = PersonId;
            this._objAddEditPeople.PopulateEditFields();
        }
    }
}
