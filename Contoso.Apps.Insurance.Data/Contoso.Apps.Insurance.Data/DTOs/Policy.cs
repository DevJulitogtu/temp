using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Contoso.Apps.Insurance.Data.DTOs
{

    // Policies
    [DataContract]
    public class Policy
    {

        ///<summary>
        /// Id (Primary key)
        ///</summary>
        [DataMember]
        public int Id { get; set; }

        ///<summary>
        /// Name (length: 50)
        ///</summary>
        [DataMember]
        public string Name { get; set; }

        ///<summary>
        /// Description (length: 500)
        ///</summary>
        [DataMember]
        public string Description { get; set; }

        ///<summary>
        /// DefaultDeductible
        ///</summary>
        [DataMember]
        public decimal DefaultDeductible { get; set; }

        ///<summary>
        /// DefaultOutOfPocketMax
        ///</summary>
        [DataMember]
        public decimal DefaultOutOfPocketMax { get; set; }

        [DataMember]
        public int PolicyHolders_Count { get; set; }

    }

}
