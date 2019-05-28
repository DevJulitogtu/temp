using System.Runtime.Serialization;

namespace Contoso.Apps.Insurance.Data
{

    // Dependents
    public class Dependent
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// PersonId
        ///</summary>
        public int PersonId { get; set; }

        ///<summary>
        /// PolicyHolderId
        ///</summary>
        public int PolicyHolderId { get; set; }

        ///<summary>
        /// Active
        ///</summary>
        public bool Active { get; set; }

        // Foreign keys
        public virtual Person Person { get; set; } // FK_Dependents_People
        public virtual PolicyHolder PolicyHolder { get; set; } // FK_Dependents_PolicyHolders

        public Dependent()
        {
            Active = false;
        }
    }

}
