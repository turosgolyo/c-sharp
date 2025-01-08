namespace EDiary.Database.Entities;

[Table("Country")]
public class CountryEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [MaxLength(50)]
    public string Name { get; set; }

    //cities
    public virtual IReadOnlyCollection<CityEntity> Cities { get; set; }
}
