namespace MoneyCounter;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Para sayma uygulamasina hosgeldiniz");
        Console.ResetColor();

        int[] moneyUnits = { 200, 100, 50, 20, 10, 5, 1 };

        try
        {
            Console.WriteLine("Lutfen para miktarini giriniz");
            int input = Convert.ToInt32(Console.ReadLine());

            foreach (int moneyUnit in moneyUnits)
            {
                int dividedNumber = input / moneyUnit;
                input -= dividedNumber * moneyUnit;
                Console.WriteLine($"{moneyUnit} = {dividedNumber}");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Yanlis girdiniz lutfen kontrol ediniz");
        }
    }
}