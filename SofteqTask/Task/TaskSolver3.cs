using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SofteqTask.Task
{
    public class TaskSolver3
    {
        int[] Arr;
        int a, b;
        public int Solve(string abn_string)
        {
            string[] abn = abn_string.Split();
            a = int.Parse(abn[0]);
            b = int.Parse(abn[1]);
            int n = int.Parse(abn[2]);
            Arr = new int[n + 1];
            Arr[a] = a;
            Arr[b] = b;
            int min = Math.Min(a, b);
            int max = Math.Max(a, b);
            a = min;
            b = max;
            return FindMaxMul(n);
        }
        public int FindMaxMul(int size)
        {
            if(size == a || size == b){
                return Arr[size];
            }
            else if(size < 0){
                return 0;
            }
            else{
                Arr[size] = Math.Max(FindMaxMul(size - b) * b, FindMaxMul(size - a) * a);
                return Arr[size];
            }
        }
    }
}
