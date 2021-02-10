using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SofteqTask.Task
{
    /*
     * Sample Input -7 0 1.234 10 -4 3
     * Sample Output 1132.856 123.456 97.575 9323.456 -17.344 56.856
     */
    public class TaskSolver1
    {
        private static TaskSolver1 instance;
        private TaskSolver1() { }
        public static TaskSolver1 getInstance()
        {
            if (instance == null)
                instance = new TaskSolver1();
            return instance;
        }
        //this coefаs i get solving system of linear equations
        private double[] coeffs = { 1, 1.2, -20, 0, 123.456 };

        public double[] Solve(string input)
        {
            string[] input_strings = input.Split();
            double[] result = new double[input_strings.Length];
            for(int i = 0; i < input_strings.Length; i++)
            {
                double argument = Double.Parse(input_strings[i]);
                double answer = 0;
                for(int j = 0; j < coeffs.Length; j++)
                {
                    answer += Math.Pow(argument, j) * coeffs[coeffs.Length - j - 1];
                }
                result[i] = answer;
            }

            return result;
        }
    }
}
