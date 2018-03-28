using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinGreedyAlgorithm {
    public class Coin {
        public string Name { get; set; }
        public double Value { get; set; }

        public Coin(Coin c) {
            this.Name = c.Name;
            this.Value = c.Value;
        }

        public Coin(String name, double value) {
            this.Name = name;
            this.Value = value;
        }

    }
}
