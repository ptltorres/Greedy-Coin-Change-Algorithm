using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinGreedyAlgorithm {

    class Program {

        static void Main(string[] args) {
            Console.Write("What is your change ?");
            double change = Convert.ToDouble(Console.ReadLine());

            List<Coin> changeCoins = GetChange(change);

            Console.WriteLine("Here's the best distribution of coins:");

            foreach (var coin in changeCoins) {
                Console.WriteLine(coin.Name);
            }
        }

        static List<Coin> GetChange(double change) {
            List<Coin> changeCoins = new List<Coin>();
            Stack<Coin> stack = GetCoinStack();

            while (change > 0 && stack.Count > 0) {
                if (stack.Peek().Value <= change) {
                    change -= stack.Peek().Value;
                    changeCoins.Add(new Coin(stack.Peek()));
                } else {
                    stack.Pop();
                }
            }
            return changeCoins;
        }

        static Stack<Coin> GetCoinStack() {
            Stack<Coin> stackCoins = new Stack<Coin>();
            stackCoins.Push(new Coin("$1c", 0.01));
            stackCoins.Push(new Coin("$5c", 0.05));
            stackCoins.Push(new Coin("$10c", 0.10));
            stackCoins.Push(new Coin("$25c", 0.25));

            return stackCoins;
        }
    }
}

