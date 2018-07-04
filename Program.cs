using System;

namespace Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            Galaxy s8 = new Galaxy("s8",100,"t-Mobile","Galaxy Rington");
            Nokia elven= new Nokia("1100",60,"Metro pcs","Nokia Rington");
            s8.DisplayInfo();
            Console.WriteLine(s8.Ring());
            Console.WriteLine(s8.Unlock());

            
            elven.DisplayInfo();
            Console.WriteLine(elven.Ring());
            Console.WriteLine(elven.Unlock());
            
        }
    }
}
