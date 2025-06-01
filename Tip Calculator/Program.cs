namespace TipCalculator
{
    class Calculator
    {
        public static void Main(string[] args)
        {
            bool option = true;
            Random random = new Random();
            int randomWholeTotal = random.Next(5, 100);
            double randomDecimalTotal = Math.Round(random.NextDouble(), 2);

            double randomTotal = randomWholeTotal + randomDecimalTotal;

            Console.WriteLine("--- WELCOME TO THE TIP CALCULATOR ---");
            Console.WriteLine("YOUR TOTAL IS: " + randomTotal);

            while (option)
            {
                Console.WriteLine("WOULD YOU LIKE TO TIP? YES OR NO");
                string answer = Console.ReadLine().ToLowerInvariant();

                bool tipApplied = false;
                switch (answer)
                {
                    case "yes":
                        Console.WriteLine("\nWHAT PERCENTAGE WOULD YOU LIKE TO TIP?");
                        Console.WriteLine("1) 15% \n2) 20%\n3) 25%\n4) CUSTOM\n5) CANCEL");
                        int numberAnswer = Convert.ToInt32(Console.ReadLine());
                        switch (numberAnswer)
                        {
                            case 1:
                                Console.WriteLine("TOTAL: " + ApplyingTip(randomTotal, 1.15));
                                tipApplied = true;
                                break;
                            case 2:
                                Console.WriteLine("TOTAL: " + ApplyingTip(randomTotal, 1.20));
                                tipApplied = true;
                                break;
                            case 3:
                                Console.WriteLine("TOTAL: " + ApplyingTip(randomTotal, 1.25));
                                tipApplied = true;
                                break;
                            case 4:
                                Console.WriteLine("\nWHAT PERCENTAGE WOULD YOU LIKE TO TIP?");
                                double percentageAnswer = Convert.ToDouble(Console.ReadLine()) / 100 + 1;
                                Console.WriteLine("TOTAL: " + ApplyingTip(randomTotal, percentageAnswer));
                                tipApplied = true;
                                break;
                            case 5:
                                Console.WriteLine("--- CANCELLING TIP ---");
                                break;
                            default:
                                option = false;
                                break;

                        }
                        if (tipApplied)
                        {
                            Console.WriteLine("--- PAYMENT SUCCESSFUL ---");
                        }
                        option = false;
                        break;
                    case "no":
                        Console.WriteLine("--- PAYMENT SUCCESSFUL ---");
                        option = false;
                        break;
                    default:
                        Console.WriteLine("--- INCORRECT OPTION ---");
                        break;
                }
            }
        }
        public static double ApplyingTip(double randomTotal, double percentage)
        {
            return Math.Round(randomTotal * percentage, 2);
        }
    }
}