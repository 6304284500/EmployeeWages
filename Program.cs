public class Program
{
    public const int IS_PART_Time = 1;
    public const int IS_FULL_Time = 2;
    public const int EMP_RATE_PER_HOUR = 20;
    public const int NUM_OF_WorkingDays = 2;
    public const int MAX_HRS_IN_MONTH = 10;
    public static int computeEmpWage()
    {
        //Variables
        int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
        //Computation
        while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WorkingDays ) 
        {
            totalWorkingDays++;
            Random random= new Random();
            int empCheck = random.Next(0,3);
            switch ( empCheck )
            {
                case IS_PART_Time:
                    empHrs =4;
                    break;
                case IS_FULL_Time:
                    empHrs =8;
                    break;
                default: empHrs = 0; break;

            }
            totalEmpHrs += empHrs ;
            Console.WriteLine("Days#:" + totalWorkingDays + "Emp Hrs:" + empHrs);
        }
        int totalEmWage = totalEmpHrs * EMP_RATE_PER_HOUR;
        Console.WriteLine("Total Emp Wage:" + totalEmWage);
        return totalEmWage;
    }
    static void Main(string[] args)
    {
        computeEmpWage();    
    }
}