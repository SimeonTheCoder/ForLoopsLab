using System;

namespace SoftUni
{
 	class NumberSequence
    {
     	static void Main(string[] args)
        {
         	int n = int.Parse(Console.ReadLine());
          	
          	int min = 99999999;
          	int max = -99999999;
          
        	for(int i = 0; i < n; i++)
            {
            	int num = int.Parse(Console.ReadLine());
              
              	min = Math.Min(min, num);
              	max = Math.Max(max, num);
            }
          
          	Console.WriteLine($"Max number: {max}");
			Console.WriteLine($"Min number: {min}");
        }
    }
}