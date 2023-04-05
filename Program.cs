internal class Program
{
    private static void Main(string[] args)
        {
        int stoSodas = 100, stoChips = 40, stoCandy = 60, restoSodas = 40, restoChips = 20, restoCandy = 40;
        Console.WriteLine("Welcome to the restocking tool.");
        Console.WriteLine("How many Sodas have been sold today? 100 are in stock");
        int xSodas = Convert.ToInt32(Console.ReadLine());
        if (xSodas > stoSodas)
        {
            Console.WriteLine("That value is too high. Stock not adjusted");
        }
        else
        {
            Console.WriteLine("There are " + (stoSodas - xSodas) + " Sodas left");
        }

        Console.WriteLine("How many Chips have been sold today? 40 are in stock");
        int xChips = Convert.ToInt32(Console.ReadLine());
        if (xChips > stoChips)
        {
            Console.WriteLine("That value is too high. Stock not adjusted");
        }
        else
        {
            Console.WriteLine("There are " + (stoChips - xChips) + " chips left");
        }
        Console.WriteLine("How many Candy have been sold today? 60 are in stock");
        int xCandy = Convert.ToInt32(Console.ReadLine());

        if (xCandy > stoCandy)
        {
            Console.WriteLine("That value is too high. Stock not adjusted");
        }
        else
        {
            Console.WriteLine("There are " + (stoCandy - xCandy) + " candy left");
        }

        Console.WriteLine("Thank you for filling out the values. Here’s what needs to be restocked.");
        if (stoSodas - xSodas <= restoSodas && stoSodas - xSodas >= 0) Console.WriteLine("Sodas needs to be restocked");
        if (stoChips - xChips <= restoChips && stoChips - xChips >= 0) Console.WriteLine("chips needs to be restocked");
        if (stoCandy - xCandy <= restoCandy && stoCandy - xCandy >= 0) Console.WriteLine("Candy needs to be restocked");
        Console.WriteLine("Goodbye!");







    }
}