namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int cash = 100;
            while (cash > 0){
                Console.WriteLine("Konzolová ruleta");
                Console.WriteLine("Zmáčkni jakoukoliv klávesu pro pokračování"); Console.ReadKey();
                Console.Clear();
                Console.WriteLine($"Tvoje peníze: {cash}");
                Console.WriteLine("Napiš: 1. Pro červenou 2. Pro černou 3. Pro zelenou");
                int userInput = int.Parse(Console.ReadLine());
                if (userInput >3||userInput < 1)
                {
                    Console.WriteLine("Špatný input");
                    Thread.Sleep(3000);
                    Console.Clear();
                    continue;
                }
                Console.WriteLine("Napiš částku kterou chceš vsadit");
                int userInputInt = Convert.ToInt32(Console.ReadLine());
                if (userInputInt > cash)
                {
                    Console.WriteLine("Nemáš dostatek peněz");
                    Thread.Sleep(3000);
                    Console.Clear();
                    continue;
                }
                Console.Clear();
                int rng = new Random().Next(1,4);
                Console.WriteLine("Ruleta se točí");
                Thread.Sleep(3000);
                if (rng == userInput)
                {
                    Console.WriteLine("Vyhrál jsi");
                    int win = userInputInt * 2;
                    cash = cash + win;
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Prohrál jsi");
                    cash = cash - userInputInt;
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }
        }
    }
}
