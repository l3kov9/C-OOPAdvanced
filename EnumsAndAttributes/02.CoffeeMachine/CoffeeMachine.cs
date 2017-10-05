using System;
using System.Collections.Generic;

namespace _02.CoffeeMachine
{
    [Serializable]
    public class CoffeeMachine
    {
        private CoffeePrice size;
        private CoffeeType type;
        private Coin coin;

        private List<CoffeeType> coffeesSold=new List<CoffeeType>();

        public void BuyCoffee(string size, string type)
        {
            this.size = (CoffeePrice)Enum.Parse(typeof(CoffeeType), size);
            this.type = (CoffeeType)Enum.Parse(typeof(CoffeeType), type);
        }

        public void InsertCoin(string coin)
        {
            this.coin = (Coin)Enum.Parse(typeof(Coin), coin);
        }

        public List<CoffeeType> CoffeesSold => this.coffeesSold;
    }
}
