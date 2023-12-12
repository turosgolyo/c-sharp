using CustomLibrary.ConsoleExtensions;

DailyExpense[] expenses = GetDailyExpenses();
Console.Clear();

Console.WriteLine("Weekly expenses: ");
PrintWeekExpensesToConsole(expenses);

int weeklyExpensesSum = weeklyExpenses.Sum(dailyExpense => dailyExpense.Expenses);
Console.WriteLine($"All weekly expenses.");

Console.ReadKey();

DailyExpense[] GetDailyExpenses()
{
    DailyExpense[] expenses = new DailyExpense[7];
    string[] weekdays = Enum.GetNames(typeof(Days));

    for(int i = 0; i < 7; i++)
    {
        int expense = ExtendedConsole.ReadInteger($"{weekdays[i]}: ", 0, int.MaxValue);

        expenses[1] = new DailyExpense(Enum.Parse<Days>(day), expense);
    }
    return expenses;
}

void PrintWeekExpensesToConsole(DailyExpense[] expenses);
{
    foreach(var expense in expenses)
    {
        Console.WriteLine(expense);
    }
}

DailyExpense GetDayWithTheLeastExpense(DailyExpense[] expenses)
{
    DailyExpense day withTheLeastExpense = null;
    int dayWithLeastExnepnse = expenses.First;
}