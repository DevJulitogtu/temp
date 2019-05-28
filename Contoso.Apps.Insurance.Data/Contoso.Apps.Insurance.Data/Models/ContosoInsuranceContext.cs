using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Contoso.Apps.Insurance.Data
{
    public class ContosoInsuranceContext : DbContext, IContosoInsuranceContext
    {
        public DbSet<Dependent> Dependents { get; set; } // Dependents

        public DbSet<Person> People { get; set; } // People

        public DbSet<Policy> Policies { get; set; } // Policies

        public DbSet<PolicyHolder> PolicyHolders { get; set; } // PolicyHolders

        public async Task<int> SaveChangesAsync()
        {
            var rows = await SaveChangesAsync();

            return rows;
        }

        static ContosoInsuranceContext()
        {
            //System.Data.Entity.Database.SetInitializer<ContosoInsuranceContext>(null);
        }

        public ContosoInsuranceContext()
            : base("Name=ContosoInsuranceContext")
        {
        }

        public ContosoInsuranceContext(string connectionString)
            : base(connectionString)
        {
        }

        //public ContosoInsuranceContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
        //    : base(connectionString, model)
        //{
        //}

        public ContosoInsuranceContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        //public ContosoInsuranceContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
        //    : base(existingConnection, model, contextOwnsConnection)
        //{
        //}

        //public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        //{
        //    var sqlValue = param.SqlValue;
        //    var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
        //    if (nullableValue != null)
        //        return nullableValue.IsNull;
        //    return (sqlValue == null || sqlValue == System.DBNull.Value);
        //}

        //protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Configurations.Add(new DependentConfiguration());
        //    modelBuilder.Configurations.Add(new PersonConfiguration());
        //    modelBuilder.Configurations.Add(new PolicyConfiguration());
        //    modelBuilder.Configurations.Add(new PolicyHolderConfiguration());
        //}

        //public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        //{
        //    modelBuilder.Configurations.Add(new DependentConfiguration(schema));
        //    modelBuilder.Configurations.Add(new PersonConfiguration(schema));
        //    modelBuilder.Configurations.Add(new PolicyConfiguration(schema));
        //    modelBuilder.Configurations.Add(new PolicyHolderConfiguration(schema));
        //    return modelBuilder;
        //}
    }
}
