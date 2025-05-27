using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex 5 5 2
            string[] a = Console.ReadLine().Split(' ');// 입력
            int e = int.Parse(a[0]);// 가지고 있던 병
            int f = int.Parse(a[1]);// 주운 병
            int c = int.Parse(a[2]);// 바꾸는데 필요한 병 
            int sum = 0;// sum은 e와f의 합  
            int k = 0; // 목의 합 
            while (true)
            {
                e += f;
                sum = e / c;
                if(sum == 0) break;
                k += sum;
                e %= c;
                f = sum;
                
            }
            Console.WriteLine(k);
        }
    }
}
