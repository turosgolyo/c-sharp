namespace EDiary.Database.Entities;

[Table("Street")]
public class StreetEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [MaxLength(50)]
    public string HouseNumber { get; set; }

    [MaxLength(50)]
    public string StreetName { get; set; }

    //students
    public virtual IReadOnlyCollection<StudentEntity> Students { get; set; }

    //city
    [ForeignKey("City")]
    public int PostalCode { get; set; }
    public virtual CityEntity City { get; set; }
}
