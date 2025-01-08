namespace EDiary.Database.Entities;

[Table("Subject")]
public class SubjectEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [MaxLength(50)]
    public string Name { get; set; }

    //students
    public virtual IReadOnlyCollection<StudentEntity> Students { get; set; }

    //grades
    public virtual IReadOnlyCollection<GradeEntity> Grades { get; set; }
}
