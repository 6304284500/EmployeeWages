


 class Program
{
    public const int IsPartTime = 1;
    public const int IsFullTime = 2;
    public const int EmpRatePerHour = 20;
    public const int NumOfWorkingDays = 2;
    public const int MaxHrsInMonth = 10;

    static void Main(string[] args)
    {
        int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
        while (totalEmpHrs <= MaxHrsInMonth && totalWorkingDays < NumOfWorkingDays )
        {
            totalWorkingDays++;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IsPartTime:
                    empHrs = 4;
                    break;
                case IsFullTime:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            totalEmpHrs += empHrs;
            Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs:" + empHrs);

        }
        int totalEmpWage = totalEmpHrs * EmpRatePerHour;
        Console.WriteLine("Total Emp Wage:" + totalEmpWage);
        
    }
}
