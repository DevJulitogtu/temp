using System.Collections.Generic;

namespace Contoso.Apps.Insurance.Data
{
    // Policies
    public class Policy
    {
        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// Name (length: 50)
        ///</summary>
        public string Name { get; set; }

        ///<summary>
        /// Description (length: 500)
        ///</summary>
        public string Description { get; set; }

        ///<summary>
        /// DefaultDeductible
        ///</summary>
        public decimal DefaultDeductible { get; set; }

        ///<summary>
        /// DefaultOutOfPocketMax
        ///</summary>
        public decimal DefaultOutOfPocketMax { get; set; }

        // Reverse navigation
        public virtual ICollection<PolicyHolder> PolicyHolders { get; set; } // PolicyHolders.FK_PolicyHolders_Policies

        public Policy()
        {
            PolicyHolders = new List<PolicyHolder>();
        }
    }

}
