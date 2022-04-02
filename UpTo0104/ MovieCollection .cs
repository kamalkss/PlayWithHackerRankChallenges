using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenges.UpTo0104
{
    public class MovieCollection
    {
        static public async Task<string> Run(int n, int m, int[] movies)
        {

            string movies_array = "";
            Stack<int> stack = new Stack<int>();

            for (int i = n; i > 0; i--)
            {
                stack.Push(i);
            }
            for (int i = 0; i < m; i++)
            {
                int counter = 0;
                int movietowatch = movies[i];
                var indexofmovie = stack.Contains(movietowatch);
                if (movietowatch == stack.Peek())
                {
                    stack.Pop();
                    movies_array += counter + ",";
                    stack.Push(movietowatch);
                }
                else
                {
                    Stack<int> nottowatch = new Stack<int>();
                    while (movietowatch != stack.Peek())
                    {
                        counter++;
                        nottowatch.Push(stack.Pop());
                    }
                    stack.Pop();
                    movies_array += counter + ",";
                    foreach (var i1 in nottowatch)
                    {
                        stack.Push(i1);
                    }
                    stack.Push(movietowatch);
                }

            }

            movies_array = movies_array.Remove(movies_array.Length - 1, 1);
            return movies_array;
        }
    }
}