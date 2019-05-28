namespace Contoso.Apps.Insurance.Data.ViewModels
{
    public class PolicyHolderViewModel
    {
        public int Id { get; set; }

        public string PolicyNumber { get; set; }

        public string LName { get; set; }

        public string FName { get; set; }

        public string Policy { get; set; }

        public decimal PolicyAmount { get; set; }

        public decimal Deductible { get; set; }

        public decimal OutOfPocketMax { get; set; }

        public System.DateTime EffectiveDate { get; set; }

        public System.DateTime ExpirationDate { get; set; }

        public bool Active { get; set; }

        public int PolicyId { get; set; }

        public int PersonId { get; set; }

        public string PersonDisplayName { get; set; }

        public int Dependents_Count { get; set; }
    }
}
