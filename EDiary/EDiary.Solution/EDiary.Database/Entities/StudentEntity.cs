namespace EDiary.Database.Entities;

[Table("Students")]
public class StudentEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int EducationId { get; set; }

    [MaxLength(50)]
    public string Name { get; set; }

    public DateTime BirthDate { get; set; }

    [MaxLength(50)]
    public string MotherName { get; set; }

    //street
    [ForeignKey("Street")]
    public int StreetId { get; set; }
    public virtual StreetEntity Street { get; set; }

    //grades
    public virtual IReadOnlyCollection<GradeEntity> Grades { get; set; }

    //subjects
    public virtual IReadOnlyCollection<SubjectEntity> Subjects { get; set; }
}
