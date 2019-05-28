namespace Contoso.Apps.Insurance.Data
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

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<Dependent> Dependents { get; set; } // Dependents.FK_Dependents_PolicyHolders

        // Foreign keys
        public virtual Person Person { get; set; } // FK_PolicyHolders_People
        public virtual Policy Policy { get; set; } // FK_PolicyHolders_Policies

        public PolicyHolder()
        {
            Active = false;
            Dependents = new System.Collections.Generic.List<Dependent>();
        }
    }
}
