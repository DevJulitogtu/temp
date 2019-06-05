// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CIMobile.Models
{

    // PolicyHolders
    public class PolicyHolder
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
        /// Active
        ///</summary>
        public bool Active { get; set; }

        ///<summary>
        /// StartDate
        ///</summary>
        public System.DateTime? StartDate { get; set; }

        ///<summary>
        /// EndDate
        ///</summary>
        public System.DateTime? EndDate { get; set; }

        ///<summary>
        /// Username (length: 50)
        ///</summary>
        public string Username { get; set; }

        ///<summary>
        /// PolicyNumber (length: 50)
        ///</summary>
        public string PolicyNumber { get; set; }

        ///<summary>
        /// PolicyId
        ///</summary>
        public int PolicyId { get; set; }

        ///<summary>
        /// FilePath (length: 500)
        ///</summary>
        public string FilePath { get; set; }

        /// <summary>
        /// PolicyAmount
        /// </summary>
        public decimal PolicyAmount { get; set; }

        ///<summary>
        /// Deductible
        ///</summary>
        public decimal Deductible { get; set; }

        ///<summary>
        /// OutOfPocketMax
        ///</summary>
        public decimal OutOfPocketMax { get; set; }

        ///<summary>
        /// EffectiveDate
        ///</summary>
        public System.DateTime EffectiveDate { get; set; }

        ///<summary>
        /// ExpirationDate
        ///</summary>
        public System.DateTime ExpirationDate { get; set; }

        public int Dependents_Count { get; set; }

        // Reverse navigation
        public List<Dependent> Dependents { get; set; } // Dependents.FK_Dependents_PolicyHolders

        // Foreign keys
        public Person Person { get; set; } // FK_PolicyHolders_People
        public Policy Policy { get; set; } // FK_PolicyHolders_Policies

        public PolicyHolder()
        {
            Active = false;
            Dependents = new System.Collections.Generic.List<Dependent>();
        }
    }

}
