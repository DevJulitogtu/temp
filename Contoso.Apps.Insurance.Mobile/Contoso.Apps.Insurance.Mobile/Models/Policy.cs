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

using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace CIMobile.Models
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

        public int PolicyHolders_Count { get; set; }

    }

}
