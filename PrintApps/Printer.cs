using System;
using System.Collections.Generic;
using System.Text;

namespace PrintApps
{


    public interface IPrinter
    {


        public void print(String input);
    
    
    };

    public class Printer:IPrinter
    {

        public void print(String input) {

            
        }

        public void print(String[] input) {

            foreach (string line in input)
            {
                Utilities.Print(line);
            }


        }

        
    };


    public static class Utilities{


        public static void Print(String input)
    {

        Console.WriteLine(input);

    }

}



}
