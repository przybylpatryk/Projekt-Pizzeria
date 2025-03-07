using System;
using Pizzeria.menus;

namespace Pizzeria
{
    public class Program
    {
        static void Main(string[] args)
        {
            LoggingMenu men = new LoggingMenu();
            men.Menu();
        }
    }
}
