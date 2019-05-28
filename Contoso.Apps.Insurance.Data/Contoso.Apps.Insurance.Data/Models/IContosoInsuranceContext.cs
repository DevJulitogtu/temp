using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Contoso.Apps.Insurance.Data
{

    public interface IContosoInsuranceContext : IDisposable
    {
        DbSet<Dependent> Dependents { get; set; } // Dependents

        DbSet<Person> People { get; set; } // People

        DbSet<Policy> Policies { get; set; } // Policies

        DbSet<PolicyHolder> PolicyHolders { get; set; } // PolicyHolders

        int SaveChanges();

        Task<int> SaveChangesAsync();

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
