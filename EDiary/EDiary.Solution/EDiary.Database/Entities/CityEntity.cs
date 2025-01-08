namespace EDiary.Database.Entities;

[Table("City")]
public class CityEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int PostalCode { get; set; }

    [MaxLength(50)]
    public string Name { get; set; }

    //country
    [ForeignKey("Country")]
    public int CountryId { get; set; }
    public virtual CountryEntity Country { get; set; }

    //streets
    public virtual IReadOnlyCollection<StreetEntity> Streets { get; set; }
}
