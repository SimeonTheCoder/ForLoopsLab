using System;

namespace SoftUni
{
 	class LeftAndRightSum
    {
     	static void Main(string[] args)
        {
         	int n = int.Parse(Console.ReadLine());
          
          	int sumLeft = 0;
          	int sumRight = 0;
          
          	for(int i = 0; i < n; i++)
            {
             	sumLeft += int.Parse(Console.ReadLine()); 
            }
          	
          	for(int i = 0; i < n; i++)
            {
             	sumRight += int.Parse(Console.ReadLine()); 
            }
          
          	if(sumLeft == sumRight)
            {
            	Console.WriteLine($"Yes, sum = {sumLeft}");
            }
          	else
            {
              	int diff = Math.Abs(sumLeft - sumRight);
              
             	Console.WriteLine($"No, diff = {diff}"); 
            }
        }
    }
}