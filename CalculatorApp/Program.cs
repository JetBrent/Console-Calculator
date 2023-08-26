namespace ConsoleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainCalc();
            Console.ReadKey();
        }
        public static void MainCalc()
        {
            bool inputnumsuccess = false;

            bool exitcode = false;
            int inputnum = 0;

            Console.WriteLine("Please input the first number that you want to use.");

            while(!inputnumsuccess)
            {
                var input = Console.ReadLine();
                bool inputnumtryparse = int.TryParse(input, out inputnum);
                if (input == "exit")
                {
                    exitcode = true;
                    inputnumsuccess = true;
                }
                else
                {
                    if (inputnumtryparse == true) inputnumsuccess = true;
                    else Console.WriteLine("Please input a number!");
                }
            }

            bool calculatorfinished = exitcode;
            
            while(!calculatorfinished)
            {
                bool inputnum2success = false;
                int inputnum2 = 0;

                Console.WriteLine("Please input the next number.");
                while (!inputnum2success)
                {
                    var secondinput = Console.ReadLine();
                    bool inputnum2tryparse = int.TryParse(secondinput, out inputnum2);
                    if (secondinput == "exit")
                    {
                        exitcode = true;
                        break;
                    }
                    else
                    {
                        if (inputnum2tryparse == true) inputnum2success = true;
                        else Console.WriteLine("Please input a number!");
                    }
                }

                calculatorfinished = exitcode;
                if (calculatorfinished) break;

                Console.WriteLine("\nPlease input the operator that you want to use. Use the following operators: \n \n X to multiply \n / to divide \n - to subtract \n + to add.\n \n Type \"exit\" if you want to quit ");

                bool inputnumcalcfinished = false;

                while (!inputnumcalcfinished)
                {
                    var inputop = Console.ReadLine();

                    if (inputop.ToLower() == "x")
                    {
                        inputnum = inputnum * inputnum2;
                        Console.WriteLine("\nResult is: " + inputnum);
                        inputnumcalcfinished = true;
                    }
                    else if (inputop == "/")
                    {
                        inputnum = inputnum / inputnum2;
                        Console.WriteLine("\nResult is: " + inputnum);
                        inputnumcalcfinished = true;
                    }
                    else if (inputop == "+")
                    {
                        inputnum = inputnum + inputnum2;
                        Console.WriteLine("\nResult is: " + inputnum);
                        inputnumcalcfinished = true;
                    }

                    else if (inputop == "-")
                    {
                        inputnum = inputnum - inputnum2;
                        Console.WriteLine("\nResult is: " + inputnum);
                        inputnumcalcfinished = true;
                    }
                    else if (inputop == "exit")
                    {
                        exitcode = true;
                        break;
                    }
                    else Console.WriteLine("Please input a valid operator!"); 
                }

                calculatorfinished = exitcode;
                if (calculatorfinished) break;

                Console.WriteLine("\nPress enter to continue...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("The previous result was: " + inputnum  + "\n");
            }
            Console.WriteLine("Thank you for using this calculator!");
        }

    }
}