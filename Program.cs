 class Program
{
    public const int IsPartTime = 1;
    public const int IsFullTime = 2;
    public const int EmpRatePerHour = 20;
    public const int NumOfWorkingDays = 2;

    static void Main(string[] args)
    {
        int empHrs = 0;
        int empWage = 0;
        int totalEmpWage = 0;

         for (int day =0; day < NumOfWorkingDays; day++)
        {

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
            empWage = empHrs * EmpRatePerHour;
            totalEmpWage += empWage;
            Console.WriteLine("EmpWage:" + empWage);

        }
        Console.WriteLine("Total Emp Wage :" + totalEmpWage);
    }
}
