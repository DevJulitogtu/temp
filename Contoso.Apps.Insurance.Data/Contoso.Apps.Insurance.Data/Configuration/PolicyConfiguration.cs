namespace Contoso.Apps.Insurance.Data
{

    // Policies
    public class PolicyConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Policy>
    {
        public PolicyConfiguration()
            : this("dbo")
        {
        }

        public PolicyConfiguration(string schema)
        {
            ToTable("Policies", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Description).HasColumnName(@"Description").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.DefaultDeductible).HasColumnName(@"DefaultDeductible").IsRequired().HasColumnType("money").HasPrecision(19,4);
            Property(x => x.DefaultOutOfPocketMax).HasColumnName(@"DefaultOutOfPocketMax").IsRequired().HasColumnType("money").HasPrecision(19,4);
        }
    }

}
