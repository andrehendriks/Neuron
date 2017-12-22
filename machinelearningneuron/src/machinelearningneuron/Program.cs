using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace machinelearningneuron
{
    public class Program
    {
        private int i;
        private int j;
        private int i2;
        private int j2;
        private int i1;
        private int j1;

        public static void Main(string[] args)
        {
            Console.WriteLine("working now:");
            
            return;  
        }

        public void LayerNet1(object H, int input, int hidden1, int hidden2, int output)
        {
            input = 4;
            hidden1 = 0;
            hidden2 = 0;
            output = 1;
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 1; j++)
                {
                    H = i * j;
                    H = i + 1 * j + 1;
                }
            }
        }

        public void MatrixX(object X)
        {
            for (i2 = 0; i2 < 4; i2++)
            {
                for (j2 = 0; j2 < 1; j2++)
                {
                    X = i2 * j2;
                    X = i2 + 1 * j2 + 1;
                }
            }
        }

        public void MatrixTrain(object T)
        {
            for (i1 = 0; i1 < 4; i1++)
            {
                for (j1 = 0; j1 < 1; j1++)
                {
                    T = i1 * j1;
                    T = i1 + 1 * j1 + 1;
                }
            }
        }
    }
}
