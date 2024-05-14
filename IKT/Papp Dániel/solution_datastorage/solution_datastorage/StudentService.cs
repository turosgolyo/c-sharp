public static class StudentService
{
    public static Student GetStudentById(List<Student> students, int id)
    {
        return students.First(x => x.Id == id);
    }
}

