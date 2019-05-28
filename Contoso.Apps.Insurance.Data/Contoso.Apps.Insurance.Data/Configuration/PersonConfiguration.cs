namespace Contoso.Apps.Insurance.Data
{

    // People
    //public class PersonConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Person>
    //{
    //    public PersonConfiguration()
    //        : this("dbo")
    //    {
    //    }

    //    public PersonConfiguration(string schema)
    //    {
    //        ToTable("People", schema);
    //        HasKey(x => x.Id);

    //        Property(x => x.Id).HasColumnName(@"Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
    //        Property(x => x.FName).HasColumnName(@"FName").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
    //        Property(x => x.LName).HasColumnName(@"LName").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
    //        Property(x => x.Dob).HasColumnName(@"DOB").IsRequired().HasColumnType("date");
    //        Property(x => x.Address).HasColumnName(@"Address").IsOptional().HasColumnType("nvarchar").HasMaxLength(400);
    //        Property(x => x.Address2).HasColumnName(@"Address2").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
    //        Property(x => x.City).HasColumnName(@"City").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
    //        Property(x => x.Suburb).HasColumnName(@"Suburb").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
    //        Property(x => x.Postcode).HasColumnName(@"Postcode").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
    //    }
    //}

}
