using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SofteqTask.Task
{
    public class TaskSolver4
    {
        public static int Solve(string mn_string)
        {
            string[] mn = mn_string.Split();
            int m = int.Parse(mn[0]);
            int n = int.Parse(mn[1]);
            return m * n + m + n;
        }
    }
}
