class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter which task you want to run:\nTask 1(Press 1)\nTask 4 (Press 4)");
        int x = int.Parse(Console.ReadLine());
        switch (x)
        {
            case 1:
                Task1();
                break;
            case 4:
                Task4();
                break;
        }
        void Task1()
        {
            Task11 instance = new Task11(420, "hi");
            instance.Method1(instance.x, instance.y);
        }
        void Task4()
        {
            Console.WriteLine("Please enter the program key: ");
            int programkey = int.Parse(Console.ReadLine());
            ApplicationLicense thekey = new ApplicationLicense(programkey);
            double a = 0;
            double b = 0;
            if (thekey.programkey == 151)
            {
                Console.WriteLine("You are using the trial version. You can either add or multiply numbers");
                Console.WriteLine("Please enter the first number: ");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the second number: ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("If you wan to add or multiply numbers, please enter 1 or 2 respectively. ");
                string choise = Console.ReadLine();
                Console.WriteLine($"Result: {ApplicationLicense.AllowTrial(a, b, choise)}");
            }
            else if (thekey.programkey == 643)
            {
                Console.WriteLine("You are using the pro version. You can add, multiply and divide numbers");
                Console.WriteLine("Please enter the first number: ");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the second number: ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("If you want to add, multiply, or divide numbers, please enter 1, 2, or 3 respectively. ");
                string choise = Console.ReadLine();
                Console.WriteLine($"Result: {ApplicationLicense.AllowPro(a, b, choise)}");
            }
            else
            {
                Console.WriteLine("You are using the common version. You can only add numbers");
                Console.WriteLine("Please enter the first number: ");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the second number: ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine($"Result: {ApplicationLicense.AllowCommon(a, b)}");
            }
        }

    }
}