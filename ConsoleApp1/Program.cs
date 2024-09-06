namespace ConsoleApp1;
using Spectre.Console;

public static class Program
{
    public static void Main()
    {
        int plrPoints = 0;
        int aiPoints = 0;
        while (true)
        {
            AnsiConsole.MarkupLine("[red]Press any key to continue[/]");
            Console.ReadKey();
            Console.Clear();
            int cislo = new Random().Next(1, 11);
            int plrNum = AnsiConsole.Prompt<int>(new TextPrompt<int>("[lightcyan1]Guess a number from 1 to 10\n[/]"));
            if (plrNum == cislo)
            {
                plrPoints++;
                AnsiConsole.MarkupLine($"[darkolivegreen2]Ai chose: {cislo}[/]");
            }
            else
            {
                aiPoints++;
                AnsiConsole.MarkupLine($"[darkolivegreen2]Ai chose: {cislo}[/]");
            }
            
            AnsiConsole.MarkupLine($"[mistyrose1]You have: {plrPoints} points[/]");
            AnsiConsole.MarkupLine($"[mediumpurple2_1]Ai has {aiPoints} points[/]");

            if (plrPoints == 5)
            {
                Console.Clear();
                AnsiConsole.MarkupLine("[hotpink]You won![/]");
                break;
            } else if (aiPoints == 5)
            {
                Console.Clear();
                AnsiConsole.MarkupLine("[rosybrown]You lost![/]");
                break;
            }
        }
        Thread.Sleep(5000);
    }
}