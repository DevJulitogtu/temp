namespace Contoso.Apps.Insurance.Data
{

    // Dependents
    public class DependentConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Dependent>
    {
        public DependentConfiguration()
            : this("dbo")
        {
        }

        public DependentConfiguration(string schema)
        {
            ToTable("Dependents", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PersonId).HasColumnName(@"PersonId").IsRequired().HasColumnType("int");
            Property(x => x.PolicyHolderId).HasColumnName(@"PolicyHolderId").IsRequired().HasColumnType("int");
            Property(x => x.Active).HasColumnName(@"Active").IsRequired().HasColumnType("bit");

            // Foreign keys
            HasRequired(a => a.Person).WithMany(b => b.Dependents).HasForeignKey(c => c.PersonId).WillCascadeOnDelete(false); // FK_Dependents_People
            HasRequired(a => a.PolicyHolder).WithMany(b => b.Dependents).HasForeignKey(c => c.PolicyHolderId).WillCascadeOnDelete(false); // FK_Dependents_PolicyHolders
        }
    }

}
