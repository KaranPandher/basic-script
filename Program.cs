using System;

namespace C_review
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 30; // Assigning an int 
            Console.WriteLine("Hello Karan! " +x); // printing hello world with the int 
           
           if  (x < 30) {
               Console.WriteLine( "X is less than 30!" );
           } else if ( x == 30) {
               Console.WriteLine( "X is equal to 30!" );
              }   else { 
               Console.WriteLine( "x is greater than 30" );   
           }

        int a = 4; 
        switch ( a ) {
            case 1 : 
                Console.WriteLine( "Value is 1!");
                break;
            case 2 : 
                Console.WriteLine( "Value is 2!");
                break;
            case 3 :
                Console.WriteLine( "Value is 3!");
                break;
            default: 
                Console.WriteLine( "Value too high");
                break;
        }
        }
    }
}
