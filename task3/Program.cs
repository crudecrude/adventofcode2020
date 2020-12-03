using System;
using System.Collections.Generic;
using System.Linq;

namespace task3
{
    class Program
    {
        class vectorMap
        {
            public int rightVector;
            public int downVector;
            public int position;
            public int trees;
        }
        static void Main(string[] args)
        {
            var lines = System.IO.File.ReadAllLines("input.txt").ToArray();
            var position = 0;
            var downVector = 1;
            var rightVector = 3;

            var lineLength = lines[0].Length;

            var trees = 0;
            for (int i = 0; i < lines.Length; i = i + downVector)
            {
                if (lines[i][position] == '#') trees++;
                position = (position + rightVector) % lineLength;
            }
            Console.WriteLine(trees);

            /*
            Right 1, down 1.
            Right 3, down 1. (This is the slope you already checked.)
            Right 5, down 1.
            Right 7, down 1.
            Right 1, down 2
             */
            //right,down,position,trees

            var x = new List<vectorMap>();
            x.Add(new vectorMap() { rightVector = 1, downVector = 1, position = 0, trees = 0 });
            x.Add(new vectorMap() { rightVector = 3, downVector = 1, position = 0, trees = 0 });
            x.Add(new vectorMap() { rightVector = 5, downVector = 1, position = 0, trees = 0 });
            x.Add(new vectorMap() { rightVector = 7, downVector = 1, position = 0, trees = 0 });
            x.Add(new vectorMap() { rightVector = 1, downVector = 2, position = 0, trees = 0 });

            for (int i = 0; i < lines.Length; i = i + downVector)
            {
                foreach (var vector in x)
                {
                    if (i % vector.downVector == 0)
                    {
                        if (lines[i][vector.position] == '#') vector.trees++;
                        vector.position = (vector.position + vector.rightVector) % lineLength;
                    }

                }

            }
            Int64 result = 1;
            foreach (var vector in x)
            {
                
                    result = result * vector.trees;
                
            }
            Console.WriteLine(result);
        }
    }
}
