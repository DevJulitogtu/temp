namespace Contoso.Apps.Insurance.Data
{

    using System.Linq;

    public class FakeContosoInsuranceContext : IContosoInsuranceContext
    {
        public System.Data.Entity.DbSet<Dependent> Dependents { get; set; }
        public System.Data.Entity.DbSet<Person> People { get; set; }
        public System.Data.Entity.DbSet<Policy> Policies { get; set; }
        public System.Data.Entity.DbSet<PolicyHolder> PolicyHolders { get; set; }

        public FakeContosoInsuranceContext()
        {
            Dependents = new FakeDbSet<Dependent>("Id");
            People = new FakeDbSet<Person>("Id");
            Policies = new FakeDbSet<Policy>("Id");
            PolicyHolders = new FakeDbSet<PolicyHolder>("Id");
        }

        public int SaveChangesCount { get; private set; }
        public int SaveChanges()
        {
            ++SaveChangesCount;
            return 1;
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync()
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1);
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken)
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1, cancellationToken);
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
