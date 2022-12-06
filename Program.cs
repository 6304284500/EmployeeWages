 class Program
{  
      public static void Main(string[] args)
        {
          int isfulltime = 1;
          int empRatePerHour = 20;

          int empHrs = 1;
          int empWage = 2;
          Random random = new Random();
          int empCheck = random.Next(0, 2);
          if (empCheck == isfulltime)
            {
                empHrs = 8;

            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * empRatePerHour;
            Console.WriteLine("Emp Wage :" + empWage);
        }
    
}
