using System;

namespace C_review
{
    class Program
    {
        static void Main(string[] args)   
        {
            // For a method to execute we must call it by name. 
            MyMethod();

            int[] myarray = new int[5] {3, 4, 5, 6, 7};
            myarray[0] = 2; //Update value by index // ARRAYS START AT ZERO! 
            Console.WriteLine( myarray[0]); // Output a value by index

            for (int i = 0; i < 5; i++ ) {
                Console.WriteLine("Array index: "+ i +" | Array Value:" + myarray[i] );
            } 
            // Lets try a while loop! 
            int n=0;
            while (n < 5) {
                Console.WriteLine( "Array Index: " + n + " | Array Value:" + myarray[n]);
                // n = n + 2
                n += 2; 
            }
            // Lety's try a foreach! // They stop themselves at the end of the collection .
            foreach ( int e in myarray) {
                Console.WriteLine("Current Foreach Value is: "+e); // It is a good idea to ask a user so they know what you want :P
            }
            Console.WriteLine(  "Please enter your name: " );
            string myname = Console.ReadLine(); // Store their input, or it will be lost forever D:
            Console.WriteLine( "Thank you, " + myname + "!" );
        }
           // Let's try making a method. 

        static void MyMethod()
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


