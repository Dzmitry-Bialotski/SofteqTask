using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SofteqTask.Task
{
    public class TaskSolver2
    {
        private static TaskSolver2 instance;
        private TaskSolver2() { }
        public static TaskSolver2 getInstance()
        {
            if (instance == null)
                instance = new TaskSolver2();
            return instance;
        }
        public double Solve(string input)
        {
            string[] inputStrings = input.Split();
            int n = int.Parse(inputStrings[0]);
            int m = int.Parse(inputStrings[1]);
            int[] A = new int[inputStrings.Length - 2];
            for(int i = 0; i < A.Length; i++){
                A[i] = int.Parse(inputStrings[i + 2]);
            }
            double result = m / A.Select(km => 1 / Convert.ToDouble(km)).Sum();
            return result;
        }
    }
}
