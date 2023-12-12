﻿using System.Reflection.Metadata.Ecma335;
using System.Text;

public class Worker
{
    private const int MONTHS = 12;
    public string Name { get; set; }

    public double SZJA
    {
        get
        {
            return 0.335 * SalarySum();
        }
    }

    public double TB
    {
        get => SZJA * 0.45;
    }

    public double NYHJ => SZJA * 0.55;

    private int[] Salaries;
    private int SalarySum() => this.Salaries.Sum(x => x);

    public Worker()
    {
        this.Salaries = GetSalaries();
    }

    public Worker(string name):this() //this meghivja a parameter nelkuli konstruktort
    {
        this.Name = name;
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        
        stringBuilder.Append(this.Name);
        stringBuilder.Append('\t');

        foreach(var salary in this.Salaries)
        {
            stringBuilder.Append(" ");
            stringBuilder.Append(salary.ToString().PadLeft(7));
        }

        return stringBuilder.ToString();
    }
    private int[] GetSalaries()
    {
        Random rnd = new Random();
        int[] salaries = new int[MONTHS];

        for (int i = 0; i < MONTHS; i++)
        {
            salaries[i] = rnd.Next(210000, 5000000);
        }

        return salaries;
    }
}


