namespace EDiary.ConsoleApp;

using EDiary.Database;
using EDiary.Database.Entities;
using Microsoft.EntityFrameworkCore;

public static class Menu
{
    public static async Task MainMenu()
    {
        Console.WriteLine("1 - Add student\n2 - Add subject\n3 - Add grade\n4 - Modify student\n5 - Exit\n");

        Console.Write("Choose an option: ");
        int option = int.Parse(Console.ReadLine());
        if(option != 5)
        {
            switch (option)
            {
                case 1:
                    await AddStudentAsync();
                    await Task.Delay(3000);
                    await MainMenu();
                    break;
                case 2:
                    await AddSubjectAsync();
                    await Task.Delay(3000);
                    await MainMenu();
                    break;
                case 3:
                    await AddGradeAsync();
                    await Task.Delay(3000);
                    await MainMenu();
                    break;
                case 4:
                    await ModifyStudentAsync();
                    await Task.Delay(3000);
                    await MainMenu();
                    break;
                default:
                    Console.WriteLine("Invalid option!");
                    await Task.Delay(3000);
                    Console.Clear();
                    await MainMenu();
                    break;
            }
        }
        else
        {
            return;
        }
    }

    async static Task AddStudentAsync()
    {
        using var dbContext = new ApplicationDbContext();
        dbContext.Database.EnsureCreated();

        Console.Write("Enter student's education id: ");
        int eduId = int.Parse(Console.ReadLine());

        Console.Write("Enter student's name: ");
        string name = Console.ReadLine();

        Console.Write("Enter student's birth date: ");
        DateTime birthDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter student's mother's name: ");
        string motherName = Console.ReadLine();

        Console.Write("Enter student's country: ");
        string country = Console.ReadLine();

        Console.Write("Enter student's city: ");
        string city = Console.ReadLine();

        Console.Write("Enter postal code: ");
        int postalCode = int.Parse(Console.ReadLine());

        Console.Write("Enter student's street: ");
        string street = Console.ReadLine();

        Console.Write("Enter student's house number: ");
        string houseNumber = Console.ReadLine();

        StudentEntity student = new StudentEntity
        {
            EducationId = eduId,
            Name = name,
            BirthDate = birthDate,
            MotherName = motherName,
            Street = new StreetEntity 
            { 
                StreetName = street,
                HouseNumber = houseNumber,
                PostalCode = postalCode,
                City = new CityEntity
                {
                    Name = city,
                    PostalCode = postalCode,
                    Country = new CountryEntity
                    {
                        Name = country
                    },
                },
            }
        };

        await dbContext.Students.AddAsync(student);
        await dbContext.SaveChangesAsync();
        Console.Clear();
    }

    public async static Task AddSubjectAsync()
    {
        using var dbContext = new ApplicationDbContext();
        dbContext.Database.EnsureCreated();

        Console.Write("Enter subject's name: ");
        string name = Console.ReadLine();

        SubjectEntity subject = new SubjectEntity
        {
            Name = name
        };

        await dbContext.Subjects.AddAsync(subject);
        await dbContext.SaveChangesAsync();
        Console.Clear();
    }

    public async static Task AddGradeAsync()
    {
        using var dbContext = new ApplicationDbContext();
        dbContext.Database.EnsureCreated();

        Console.Write("Enter student's education id: ");
        int eduId = int.Parse(Console.ReadLine());

        Console.Write("Enter subject's name: ");
        string subjectName = Console.ReadLine();
        
        Console.Write("Enter grade: ");
        int grade = int.Parse(Console.ReadLine());
        
        Console.Write("Enter date: ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        GradeEntity gradeEntity = new GradeEntity
        {
            Student = await dbContext.Students.FirstOrDefaultAsync(s => s.EducationId == eduId),
            Subject = await dbContext.Subjects.FirstOrDefaultAsync(s => s.Name == subjectName),
            Grade = grade,
            Date = date
        };

        await dbContext.Grades.AddAsync(gradeEntity);
        await dbContext.SaveChangesAsync();
        Console.Clear();
    }

    public async static Task ModifyStudentAsync()
    {
        using var dbContext = new ApplicationDbContext();
        dbContext.Database.EnsureCreated();

        Console.Write("Enter student's education id: ");
        int eduId = int.Parse(Console.ReadLine());
        StudentEntity student = await dbContext.Students.FirstOrDefaultAsync(s => s.EducationId == eduId);

        Console.Write("Enter student's name: ");
        student.Name = Console.ReadLine();

        Console.Write("Enter student's birth date: ");
        student.BirthDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter student's mother's name: ");
        student.MotherName = Console.ReadLine();

        Console.Write("Enter student's country: ");
        string country = Console.ReadLine();

        Console.Write("Enter student's city: ");
        string city = Console.ReadLine();

        Console.Write("Enter postal code: ");
        int postalCode = int.Parse(Console.ReadLine());

        Console.Write("Enter student's street: ");
        string street = Console.ReadLine();

        Console.Write("Enter student's house number: ");
        string houseNumber = Console.ReadLine();

        student.Street = new StreetEntity
        {
            StreetName = street,
            HouseNumber = houseNumber,
            PostalCode = postalCode,
            City = new CityEntity
            {
                Name = city,
                PostalCode = postalCode,
                Country = new CountryEntity
                {
                    Name = country
                },
            },
        };
        await dbContext.SaveChangesAsync();
        Console.Clear();
        
    }
}

