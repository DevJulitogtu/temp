namespace Contoso.Apps.Insurance.Data
{

    // PolicyHolders
    //public class PolicyHolderConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PolicyHolder>
    //{
    //    public PolicyHolderConfiguration()
    //        : this("dbo")
    //    {
    //    }

    //    public PolicyHolderConfiguration(string schema)
    //    {
    //        ToTable("PolicyHolders", schema);
    //        HasKey(x => x.Id);

    //        Property(x => x.Id).HasColumnName(@"Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
    //        Property(x => x.PersonId).HasColumnName(@"PersonId").IsRequired().HasColumnType("int");
    //        Property(x => x.Active).HasColumnName(@"Active").IsRequired().HasColumnType("bit");
    //        Property(x => x.StartDate).HasColumnName(@"StartDate").IsOptional().HasColumnType("date");
    //        Property(x => x.EndDate).HasColumnName(@"EndDate").IsOptional().HasColumnType("date");
    //        Property(x => x.Username).HasColumnName(@"Username").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
    //        Property(x => x.PolicyNumber).HasColumnName(@"PolicyNumber").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
    //        Property(x => x.PolicyId).HasColumnName(@"PolicyId").IsRequired().HasColumnType("int");
    //        Property(x => x.FilePath).HasColumnName(@"FilePath").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
    //        Property(x => x.PolicyAmount).HasColumnName(@"PolicyAmount").IsRequired().HasColumnType("money").HasPrecision(19, 4);
    //        Property(x => x.Deductible).HasColumnName(@"Deductible").IsRequired().HasColumnType("money").HasPrecision(19,4);
    //        Property(x => x.OutOfPocketMax).HasColumnName(@"OutOfPocketMax").IsRequired().HasColumnType("money").HasPrecision(19,4);
    //        Property(x => x.EffectiveDate).HasColumnName(@"EffectiveDate").IsRequired().HasColumnType("date");
    //        Property(x => x.ExpirationDate).HasColumnName(@"ExpirationDate").IsRequired().HasColumnType("date");

    //        // Foreign keys
    //        HasRequired(a => a.Person).WithMany(b => b.PolicyHolders).HasForeignKey(c => c.PersonId).WillCascadeOnDelete(false); // FK_PolicyHolders_People
    //        HasRequired(a => a.Policy).WithMany(b => b.PolicyHolders).HasForeignKey(c => c.PolicyId).WillCascadeOnDelete(false); // FK_PolicyHolders_Policies
    //    }
    //}

}
