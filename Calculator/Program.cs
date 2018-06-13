using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator {
    public class Program {

        public static int Multiply(string numbers) {
            var array = numbers.Split(',');
            List<int> Ints = new List<int>();
            foreach (var str in array) {
                int i;
                var success = int.TryParse(str, out i);
                if (!success) {
                    Console.WriteLine("Some term is not an integer");
                    return -1;
                }
                Ints.Add(i);
            }
            var sum = 1;
            foreach(var i in Ints) {
                sum *= i;
            }

            return sum;

        }

        public static int Calculator(string numbers) {
            var array = numbers.Split(',');
            List<int> Ints = new List<int>();
            foreach(var str in array) {
                int i;
                var success = int.TryParse(str, out i);
                if(!success) {
                    Console.WriteLine("Some term is not an integer");
                    return -1; 
                }
                Ints.Add(i);
            }
            var sum = Ints.Sum();

            return sum;
        }

        static void Main(string[] args) {
            Console.Write("Enter numbers to add: ");
            var read = Console.ReadLine();
            var answer = Calculator(read);
            Console.WriteLine($"Add ({read}) is {answer}");
        }
    }
}