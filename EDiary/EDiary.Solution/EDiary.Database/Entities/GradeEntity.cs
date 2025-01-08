namespace EDiary.Database.Entities;

[Table("Grade")]
public class GradeEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public int Grade { get; set; }

    public DateTime Date { get; set; }

    //student
    [ForeignKey("Student")]
    public int EducationId { get; set; }
    public virtual StudentEntity Student { get; set; }

    //subject
    [ForeignKey("Subject")]
    public int SubjectId { get; set; }
    public virtual SubjectEntity Subject { get; set; }
}
