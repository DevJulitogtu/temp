using System.Runtime.Serialization;

namespace Contoso.Apps.Insurance.Data.DTOs
{
    // Dependents
    [DataContract]
    public class Dependent
    {
        ///<summary>
        /// Id (Primary key)
        ///</summary>
        [DataMember]
        public int Id { get; set; }

        ///<summary>
        /// PersonId
        ///</summary>
        [DataMember]
        public int PersonId { get; set; }

        ///<summary>
        /// PolicyHolderId
        ///</summary>
        [DataMember]
        public int PolicyHolderId { get; set; }

        ///<summary>
        /// Active
        ///</summary>
        [DataMember]
        public bool Active { get; set; }

        // Foreign keys
        [DataMember]
        public Person Person { get; set; } // FK_Dependents_People

        [DataMember]
        public string PolicyHolderName { get; set; }
        //[DataMember]
        //public PolicyHolder PolicyHolder { get; set; } // FK_Dependents_PolicyHolders

        public Dependent()
        {
            Active = false;
        }
    }

}
