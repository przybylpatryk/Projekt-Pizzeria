using System;
namespace Pizzeria.menus;

public class LoggingMenu
{
	public void Menu()
	{
        //wizuanie ładnie wyświetla
        Console.WriteLine("///////////////////////////////////////////");
        Console.WriteLine("         Prosimy o zalogowanie      ");
        Console.WriteLine("///////////////////////////////////////////");
        Console.WriteLine();
        Console.Write("Nazwa użytkownika: ");

        //sprawdzanie czy użytkownik nie klika poprostu entera
        string? username = Console.ReadLine();
        while (username == "")
        {
            Console.Write("Pusto!, spróbuj ponownie: ");
            username = Console.ReadLine();
        }
        Console.Write("\nHasło: ");

        //sprawdzanie czy użytkownik nie klika poprostu entera
        string? password = Console.ReadLine();
        while (password == "")
        {
            Console.Write("Pusto!, spróbuj ponownie: ");
            password = Console.ReadLine();
        }
    }
}
