using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Contoso.Apps.Insurance.Data.DTOs
{
    // People
    [DataContract]
    public class Person
    {
        ///<summary>
        /// Id (Primary key)
        ///</summary>
        [DataMember]
        public int Id { get; set; }

        ///<summary>
        /// FName (length: 50)
        ///</summary>
        [DataMember]
        public string FName { get; set; }

        ///<summary>
        /// LName (length: 100)
        ///</summary>
        [DataMember]
        public string LName { get; set; }

        ///<summary>
        /// DOB
        ///</summary>
        [DataMember]
        public System.DateTime Dob { get; set; }

        ///<summary>
        /// Address (length: 400)
        ///</summary>
        [DataMember]
        public string Address { get; set; }

        ///<summary>
        /// Address2 (length: 200)
        ///</summary>
        [DataMember]
        public string Address2 { get; set; }

        ///<summary>
        /// City (length: 100)
        ///</summary>
        [DataMember]
        public string City { get; set; }

        ///<summary>
        /// Suburb (length: 100)
        ///</summary>
        [DataMember]
        public string Suburb { get; set; }

        ///<summary>
        /// Postcode (length: 10)
        ///</summary>
        [DataMember]
        public string Postcode { get; set; }

        // Reverse navigation
        [DataMember]
        public List<Dependent> Dependents { get; set; } // Dependents.FK_Dependents_People
        //[DataMember]
        //public System.Collections.Generic.List<PolicyHolder> PolicyHolders { get; set; } // PolicyHolders.FK_PolicyHolders_People

        [DataMember]
        public string DisplayName { get; set; }
        //public string DisplayName => $"{FName} {LName} of {City}, {Suburb}";

        public Person()
        {
            Dependents = new List<Dependent>();
            //PolicyHolders = new System.Collections.Generic.List<PolicyHolder>();
        }

        public override string ToString()
        {
            return $"{FName}    ({Dob.ToLongDateString()})";
        }
    }

}
