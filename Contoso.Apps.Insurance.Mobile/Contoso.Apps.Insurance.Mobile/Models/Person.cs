// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.51

using System.Runtime.Serialization;

#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

namespace CIMobile.Models
{

    // People
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
        public System.Collections.Generic.List<Dependent> Dependents { get; set; } // Dependents.FK_Dependents_People
        //[DataMember]
        //public System.Collections.Generic.List<PolicyHolder> PolicyHolders { get; set; } // PolicyHolders.FK_PolicyHolders_People

        public string DisplayName { get; set; }
        //public string DisplayName => $"{FName} {LName} of {City}, {Suburb}";

        public Person()
        {
            Dependents = new System.Collections.Generic.List<Dependent>();
            //PolicyHolders = new System.Collections.Generic.List<PolicyHolder>();
        }

        public override string ToString()
        {
            return $"{FName}    ({Dob.ToLongDateString()})";
        }
    }

}
