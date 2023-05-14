using System;
/* 
I added a character counter to what the entry class tracks.
This could be used to sort by response length in the future.
*/

class Program
{
    static void Main(string[] args)
    {
        Menu _menu = new Menu();
        _menu.Display();
    }
}