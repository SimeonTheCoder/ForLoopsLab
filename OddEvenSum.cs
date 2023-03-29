using System;

namespace SoftUni
{
 	class OddEvenSum
    {
     	static void Main(string[] args)
        {
         	int n = int.Parse(Console.ReadLine());
          
          	int sumLeft = 0;
          	int sumRight = 0;
          
          	for(int i = 0; i < n; i++)
            {
              	int num = int.Parse(Console.ReadLine());
              
             	if(i % 2 == 0)
                {
                 	sumLeft += num; 
                }
              	else
                {
                 	sumRight += num; 
                }
            }
          
          	if(sumLeft == sumRight)
            {
            	Console.WriteLine($"Yes\nSum = {sumLeft}");
            }
          	else
            {
              	int diff = Math.Abs(sumLeft - sumRight);
              
             	Console.WriteLine($"No\nDiff = {diff}"); 
            }
        }
    }
}