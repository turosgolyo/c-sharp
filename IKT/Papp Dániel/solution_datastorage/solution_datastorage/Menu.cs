using Custom.Library.ConsoleExtensions;

public static class Menu
{
    public static async void Main()
    {
        
        List<Student> students = await FileService.ReadFromFileAsync("students.txt");
        int choice = 0;
        choice = ExtendedConsole.ReadInteger("Valasszon az alabbiak kozul\n1 - Lekérés\n2 - Letrehozas\n3 - Modositas\n");
        switch(choice)
        {
            case 1:
                GetById(students);
                break;
            case 2:
                Create();
                break;
            case 3:
                break;
            case 4:
                break;
            default: 
                Console.WriteLine("Ilyen funkcio nem letezik!");
                break;
        }
        Main();
    }
    public static async void GetById(List<Student> students)
    {
        int id = ExtendedConsole.ReadInteger("Adja meg a diak azonositojjat: ");
        Student student = StudentService.GetStudentById(students, id);

        Console.WriteLine(student);
    }
    public static async void Create()
    {
        int id = ExtendedConsole.ReadInteger("\nAdja meg a diak azonositojat!");
        string name = ExtendedConsole.ReadString("\nAdja meg a diak nevet!");

        List<Subject> subjects = new List<Subject>();
        char choice = ExtendedConsole.ReadChar("\nSzeretne hozzaadni tantargyat? (y/n)", 'y', 'n');

        while (choice == 'y')
        {
            string subjectName = ExtendedConsole.ReadString("\nAdja meg a tantargy nevet!");
            string data = ExtendedConsole.ReadString("\nAdja meg a jegyeket [,] - el elvalasztva!");
            List<int> subjectGrades = data.Split(',').Select(int.Parse).ToList();
            Subject subject = new Subject
            {
                SubjectName = subjectName,
                Grades = subjectGrades
            };
            subjects.Add(subject);
            
            choice = ExtendedConsole.ReadChar("\nSzeretne meg hozzaadni tantargyat? (y/n)", 'y', 'n');
        }

        Student newStudent = new Student
        {
            Id = id,
            Name = name,
            Subjects = subjects
        };

        await FileService.AppendToFileAsync("students.txt", newStudent);
    }
}
