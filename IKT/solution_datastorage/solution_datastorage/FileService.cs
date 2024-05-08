
using System.Text;

public static class FileService
{
    #region File Read
    public static async Task<List<Student>> ReadFromFileAsync(string fileName)
    {
        List<Student> students = new List<Student>();
        Student student = null;
        string line = string.Empty;
        string[] data = null;

        string path = Path.Combine("source", fileName);

        using FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None);
        using StreamReader sr = new StreamReader(fs, Encoding.UTF8);


        while (!sr.EndOfStream)
        {
            //adatok
            line = await sr.ReadLineAsync();
            data = line.Split("\t");

            //tantargy adatok beolvasasa
            List<Subject> subjects = new List<Subject>();
            int dataCount = data.Length;
            for(int i = 2; i <= dataCount - 2; i = i+2)
            {
                Subject subject = new Subject
                {
                    SubjectName = data[i],
                    Grades = data[i+1].Split(',').Select(int.Parse).ToList()
                };
                subjects.Add(subject);
            }

            //tanulo adatok beolvasasa
            student = new Student
            {
                Id = int.Parse(data[0]),
                Name = data[1],
                Subjects = subjects
            };
            students.Add(student);
        }
        return students;
    }
    #endregion
    #region File Write
    public static async Task AppendToFileAsync(string fileName, Student student)
    {
        string path = Path.Combine("Source", fileName); ;

        using FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.None, 128);
        using StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

        await sw.WriteAsync($"\n{student.Id}\t{student.Name}\t");
        foreach(Subject subject in student.Subjects)
        {
            await sw.WriteAsync($"{subject.SubjectName}\t");
            foreach(int grade in subject.Grades)
            {
                await sw.WriteAsync($"{grade},");
            }
        }
    }
    #endregion
}
