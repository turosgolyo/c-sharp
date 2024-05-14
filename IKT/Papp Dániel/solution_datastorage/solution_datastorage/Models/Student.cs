using System.Text;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Subject> Subjects { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"{Id} - ");
        sb.Append($"{Name}\n");
        foreach (Subject subject in Subjects)
        {
            sb.Append($"{subject}\n");
        }
        return sb.ToString();
    }
}

