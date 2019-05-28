using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Contoso.Apps.Insurance.Data
{
    public class FakeContosoInsuranceContext : IContosoInsuranceContext
    {
        public DbSet<Dependent> Dependents { get; set; }

        public DbSet<Person> People { get; set; }

        public DbSet<Policy> Policies { get; set; }

        public DbSet<PolicyHolder> PolicyHolders { get; set; }

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

        public Task<int> SaveChangesAsync()
        {
            ++SaveChangesCount;
            return Task<int>.Factory.StartNew(() => 1);
        }

        public Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken)
        {
            ++SaveChangesCount;
            return Task<int>.Factory.StartNew(() => 1, cancellationToken);
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
