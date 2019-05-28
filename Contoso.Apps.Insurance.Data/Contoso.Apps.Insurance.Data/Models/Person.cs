using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contoso.Apps.Insurance.Data
{
    // People
    [Table("People")]
    public class Person
    {
        ///<summary>
        /// Id (Primary key)
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        /// FName (length: 50)
        ///</summary>
        public string FName { get; set; }

        ///<summary>
        /// LName (length: 100)
        ///</summary>
        public string LName { get; set; }

        ///<summary>
        /// DOB
        ///</summary>
        public System.DateTime Dob { get; set; }

        ///<summary>
        /// Address (length: 400)
        ///</summary>
        public string Address { get; set; }

        ///<summary>
        /// Address2 (length: 200)
        ///</summary>
        public string Address2 { get; set; }

        ///<summary>
        /// City (length: 100)
        ///</summary>
        public string City { get; set; }

        ///<summary>
        /// Suburb (length: 100)
        ///</summary>
        public string Suburb { get; set; }

        ///<summary>
        /// Postcode (length: 10)
        ///</summary>
        public string Postcode { get; set; }

        // Reverse navigation
        public virtual ICollection<Dependent> Dependents { get; set; } // Dependents.FK_Dependents_People

        public virtual ICollection<PolicyHolder> PolicyHolders { get; set; } // PolicyHolders.FK_PolicyHolders_People

        public Person()
        {
            Dependents = new List<Dependent>();
            PolicyHolders = new List<PolicyHolder>();
        }
    }

}
