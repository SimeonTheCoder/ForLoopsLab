using System;

class VowelSum
{
    static void Main()
    {
        string s = Console.ReadLine();
      
        int sum = 0;
      
        for(int i = 0; i < s.Length; i++)
        {
          	char c = s[i];
          
            switch (c)
            {
                case 'a':
                    sum += 1;
                
                    break;
                
                case 'e':
                    sum += 2;
                
                    break;
                
                case 'i':
                    sum += 3;
                
                    break;
                
                case 'o':
                    sum += 4;
                
                    break;
                
                case 'u':
                    sum += 5;
                
                    break;
            }
        }
      
        Console.WriteLine(sum);
    }
}