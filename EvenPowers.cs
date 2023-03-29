using System;

namespace SoftUni
{
 	class EvenPrograms
    {
    	static void Main(string[] args)
        {
         	int n = int.Parse(Console.ReadLine());
          
			int res = 1;
          
        	for(int i = 0; i <= n; i ++)
            {
              	if(i % 2 == 0) {
                	Console.WriteLine(res);
                }
             
              	res *= 2;
            }
        }
    }
}