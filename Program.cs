﻿using System.Net.Http.Headers;

public class EmpWageBuilderObject
{
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;

    private string company;
    private int empRatePerHour;
    public int numOfWorkingDays;
    public int maxHoursPerMonth;
    private int totalEmpWage;

    public EmpWageBuilderObject(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
    {
        this.company = company;
        this.empRatePerHour = empRatePerHour;
        this.numOfWorkingDays = numOfWorkingDays;
        this.maxHoursPerMonth = maxHoursPerMonth;
    }
    public void computeEmpWage()
    {
        int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
        while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
        {
            totalWorkingDays++;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {

                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            totalEmpHrs += empHrs;
            Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs" + empHrs);
        }
        totalEmpWage = totalEmpHrs * this.empRatePerHour;
        Console.WriteLine("Total Emp Wage for Company:" + company + "is:" + totalEmpWage); ;
    }
    public string toSring()
    {
        return "Total Emp Wage for Company:" + this.company + "is:" + this.totalEmpWage;
    }
}
  class Program
    {
     static void Main(string[] args)
    {
        EmpWageBuilderObject dMart = new EmpWageBuilderObject ("DMart",20,2,10);
        EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
        dMart.computeEmpWage();
        Console.WriteLine(dMart .toSring());
        reliance.computeEmpWage ();
        Console.WriteLine (reliance .toSring());
    }
      
 }