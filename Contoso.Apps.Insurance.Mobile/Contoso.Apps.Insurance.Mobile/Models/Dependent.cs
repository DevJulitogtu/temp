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
        public Person Person { get; set; } // FK_Dependents_People

        public string PolicyHolderName { get; set; }
        //[DataMember]
        //public PolicyHolder PolicyHolder { get; set; } // FK_Dependents_PolicyHolders

        public Dependent()
        {
            Active = false;
        }
    }

}
