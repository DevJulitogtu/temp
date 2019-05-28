namespace Contoso.Apps.Insurance.Data
{

    public interface IContosoInsuranceContext : System.IDisposable
    {
        System.Data.Entity.DbSet<Dependent> Dependents { get; set; } // Dependents
        System.Data.Entity.DbSet<Person> People { get; set; } // People
        System.Data.Entity.DbSet<Policy> Policies { get; set; } // Policies
        System.Data.Entity.DbSet<PolicyHolder> PolicyHolders { get; set; } // PolicyHolders

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);
    }

}
