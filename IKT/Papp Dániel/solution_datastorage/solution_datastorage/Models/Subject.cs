using System.Text;

public class Subject
{
    public string SubjectName { get; set; }
    public List<int> Grades { get; set; }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"{SubjectName}\n");
        foreach (int grade in Grades) 
        {  
            sb.Append($"{grade} "); 
        }
        return sb.ToString();
    }
}
