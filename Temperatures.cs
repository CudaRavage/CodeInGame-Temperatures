using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string temps = Console.ReadLine(); // the n temperatures expressed as integers ranging from -273 to 5526


			string[] tempsplit = temps.Split(' ');			//turn console input into string array
	
			if (temps == "")
				Console.WriteLine ("0");					//if console is null, return "0"

			else {

				int[] myInts = Array.ConvertAll (tempsplit, int.Parse); // convert array into ints
				Array.Sort (myInts); //sort array of ints

				int[] revInts = Array.ConvertAll (tempsplit, int.Parse); // convert array into ints
				Array.Sort (revInts); //sort array of ints
				Array.Reverse (revInts); // reverse sorted array

				int poss = 0;
				int negg = 0;

				for (int i = 0; i < myInts.Length; i++) 
				{ 											// find closest POS
					if (myInts [i] > 0) {
						//Console.WriteLine ("Pos is {0}", myInts [i]);
						poss = myInts [i];
						goto jumpOut;
					}
				}

				jumpOut:

				for (int i = 0; i < revInts.Length; i++) 
				{ 											// find closest NEG

					if (revInts [i] < 0) {
						//Console.WriteLine ("Neg is {0}", revInts [i]);
						negg = revInts [i];
						goto nextJump;
					}


				}

				nextJump: //===================================== Closest neg and pos found and assigned
if (poss + negg == -1)
Console.WriteLine ("1");

else
{



				if (poss + negg == 0)
					Console.WriteLine (poss);
				else if (poss + negg < 0)
					Console.WriteLine (negg);
				else if (poss + negg > 0)
					Console.WriteLine (poss);
}

        
        
        
			}
        
    }
}