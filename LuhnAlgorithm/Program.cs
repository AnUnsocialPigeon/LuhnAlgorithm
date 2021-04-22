using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuhnAlgorithm {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(LuhnAlgorithm(Console.ReadLine()));
            Console.ReadLine();
        }
        public static bool LuhnAlgorithm(string n) {
            int[] nums = new int[n.Length];
            int total = 0;
            for (int i = 0; i < n.Length; i++) {
                nums[i] = int.Parse(n[i].ToString()) * (n.Length % 2 == 0 && i % 2 == 0 ? 2 : n.Length % 2 == 1 && i % 2 == 1 ? 2 : 1);
                if (nums[i].ToString().Length != 1) nums[i] = int.Parse(nums[i].ToString()[0].ToString()) + int.Parse(nums[i].ToString()[1].ToString());
                total += nums[i];
            }
            if (total % 10 == 0) return true;
            return false;
        }
    }
}
