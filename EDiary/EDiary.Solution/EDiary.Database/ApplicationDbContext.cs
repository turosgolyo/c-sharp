namespace EDiary.Database;

public class ApplicationDbContext : DbContext
{
    public DbSet<StudentEntity> Students { get; set; }
    public DbSet<GradeEntity> Grades { get; set; }
    public DbSet<SubjectEntity> Subjects { get; set; }
    public DbSet<CountryEntity> Countries { get; set; }
    public DbSet<CityEntity> Cities { get; set; }
    public DbSet<StreetEntity> Streets { get; set; }

    public ApplicationDbContext() : base()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EDiaryDB;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");
    }
}
