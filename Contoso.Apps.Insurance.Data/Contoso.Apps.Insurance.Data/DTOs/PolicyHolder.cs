using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Contoso.Apps.Insurance.Data.DTOs
{
    // PolicyHolders
    [DataContract]
    [Table("PolicyHolders")]
    public class PolicyHolder
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
        /// Active
        ///</summary>
        [DataMember]
        public bool Active { get; set; }

        ///<summary>
        /// StartDate
        ///</summary>
        [DataMember]
        public DateTime? StartDate { get; set; }

        ///<summary>
        /// EndDate
        ///</summary>
        [DataMember]
        public DateTime? EndDate { get; set; }

        ///<summary>
        /// Username (length: 50)
        ///</summary>
        [DataMember]
        public string Username { get; set; }

        ///<summary>
        /// PolicyNumber (length: 50)
        ///</summary>
        [DataMember]
        public string PolicyNumber { get; set; }

        ///<summary>
        /// PolicyId
        ///</summary>
        [DataMember]
        public int PolicyId { get; set; }

        ///<summary>
        /// FilePath (length: 500)
        ///</summary>
        [DataMember]
        public string FilePath { get; set; }

        /// <summary>
        /// PolicyAmount
        /// </summary>
        [DataMember]
        public decimal PolicyAmount { get; set; }

        ///<summary>
        /// Deductible
        ///</summary>
        [DataMember]
        public decimal Deductible { get; set; }

        ///<summary>
        /// OutOfPocketMax
        ///</summary>
        [DataMember]
        public decimal OutOfPocketMax { get; set; }

        ///<summary>
        /// EffectiveDate
        ///</summary>
        [DataMember]
        public DateTime EffectiveDate { get; set; }

        ///<summary>
        /// ExpirationDate
        ///</summary>
        [DataMember]
        public DateTime ExpirationDate { get; set; }

        [DataMember]
        public int Dependents_Count { get; set; }

        // Reverse navigation
        [DataMember]
        public List<Dependent> Dependents { get; set; } // Dependents.FK_Dependents_PolicyHolders

        // Foreign keys
        [DataMember]
        public Person Person { get; set; } // FK_PolicyHolders_People
        [DataMember]
        public Policy Policy { get; set; } // FK_PolicyHolders_Policies

        public PolicyHolder()
        {
            Active = false;
            Dependents = new List<Dependent>();
        }
    }

}
