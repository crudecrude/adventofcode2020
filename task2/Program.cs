using System;
using System.Linq;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = System.IO.File.ReadAllLines("input.txt");

            //

            //3-10 v: vvgvvvvvvtvvvvh

            var passwords = lines.Select(x => {
                var a = x.Split(' ');
                
                return new Tuple<int, int, char, string>(Int32.Parse(a[0].Split('-')[0]),Int32.Parse(a[0].Split('-')[1]), a[1][0],a[2].Trim());
            });
            int correctPasswords = 0;
            foreach (var password in passwords)
            {
                var charCount = 0;
                for(int i=0;i<password.Item4.Length;i++)
                {
                    if (password.Item4[i] == password.Item3) charCount++;
                }
                if (password.Item1 <= charCount && charCount <= password.Item2)
                    correctPasswords++;
            }
            Console.WriteLine(correctPasswords);
            correctPasswords = 0;
            foreach (var password in passwords)
            {
                var contains1 = (password.Item4[password.Item1-1] == password.Item3);
                var contains2 = (password.Item4[password.Item2-1] == password.Item3);
                if (contains1 ^ contains2) correctPasswords++;
            }
                
                    
            
            Console.WriteLine(correctPasswords);
        }
    }
}
