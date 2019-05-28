using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contoso.Apps.Insurance.Data
{
    // Dependents
    [Table("Dependents")]
    public class Dependent
    {
        ///<summary>
        /// Id (Primary key)
        ///</summary>
        [Key]
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
