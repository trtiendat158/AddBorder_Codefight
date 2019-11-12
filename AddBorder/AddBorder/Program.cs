using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddBorder
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        string[] addBorder(string[] picture)
        {
            List<string> answer = new List<string>();
            string decoratedRow = string.Empty;
            for (int i = 0; i < picture[0].Length + 2; i++)
            {
                decoratedRow += "*";
            }
            answer.Add(decoratedRow);
            for (int i = 0; i < picture.Length; i++)
            {
                string row = "*";
                for (int j = 0; j < picture[0].Length; j++)
                {
                    row += picture[i][j];
                }
                row += "*";
                answer.Add(row);
            }
            answer.Add(decoratedRow);
            return answer.ToArray();
        }

        
    }
}
