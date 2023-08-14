using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    internal class Program
    {
        static void DrawTree(int height) // creation of DrawTree one that containts and height one that is an int
        {
            for (int i = 0; i < height; i++) // a for loop that says if what is within the () happnes to what is below
            {
                for (int j = 0; j < height - i - 1; j++) // a foor loop that does the same as above but with a diffrent fuction. what is below creates blank space where it is needed
                {
                    Console.Write(" "); // writes a blank
                }
                for (int k = 0; k < 2 * i + 1; k++) // a for loop that does the same as the two above. This one creatres the stars the make up the tree
                {
                    Console.Write("*"); // the start that is created
                }
                Console.WriteLine(); // Writes a line under the creation of stars the line part being what sends it to a new line one that is below all the start

                static void Main(string[] args) // a static maincreated for input
                {
                    // This here below is what intakes the number one has put in and transports it to the creation part of the process. aka this is what tells the program what was typed and how tall one should make the tree.
                    Console.Write("skriv højden af træet: "); 
                    int treeHeight = int.Parse(Console.ReadLine()); 

                    DrawTree(treeHeight);
                }
               


            }
        }
    }
}
// note debug is not fond of this 