class Program
{
    public const int IsPartTime = 1;
    public const int IsFullTime = 2;
    public const int EmpRatePerHour = 3;
    static void Main(string[] args)
    {
        int empHrs = 0;
        int empWage = 0;
        Random random= new Random();
        //Computation
        int empCheck =random.Next(0,3);
        switch(empCheck)
        {
            case IsPartTime: 
                empHrs = 4;
                break; 

            case IsFullTime:
                 empHrs= 5;
                break;
            default: 
                empHrs = 0;
                break;

        }
        empWage = empHrs * EmpRatePerHour;
        Console.WriteLine("Emp Wage:" + empWage);
    }
}
