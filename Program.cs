namespace ClockAngle;

class Program {
    static double clockAngle(int hourHand, int minuteHand)
    {
        if (hourHand < 0 || minuteHand < 0 || hourHand > 12 || minuteHand > 60)
        {
            Console.WriteLine("Invalid Input");
        }

        if (hourHand == 12)
        {
            hourHand = 0;
        }

        if (minuteHand == 60)
        {
            minuteHand = 0;
            hourHand++;
        }

        double hourAngle = 0.5 * (hourHand * 60 + minuteHand);
        double minuteAngle = 6 * minuteHand;

        double clockAngle = Math.Abs(hourAngle - minuteAngle);

        return Math.Min(360 - clockAngle, clockAngle);
    }

    public static void Main()
    {
        string hour, minute;
        int intHour, intMinute;
        
        Console.WriteLine("Clock Angle Problem");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Press any key to continue...");
        
        while (Console.ReadKey().Key != ConsoleKey.X)
        {
            Console.Write("Enter the hour: ");
            hour = Console.ReadLine();
            Console.Write("Enter the minute: ");
            minute = Console.ReadLine();

            intHour = Convert.ToInt32(hour);
            intMinute = Convert.ToInt32(minute);
        
            Console.Write("Angle: ");
            Console.WriteLine(clockAngle(intHour, intMinute));
            Console.WriteLine("Enter X in your keyboard if you want to exit");
        }
    }
}