using System;
using System.Collections.Generic;

public class CoffeeMachine
{
    public CoffeeMachine()
    {
        this.CoffeesSold = new List<CoffeeType>();
    }

    public List<CoffeeType> CoffeesSold { get; }
    public int Coins { get; private set; }

    public void BuyCoffee(string size, string type)
    {
        CoffeeType coffee = (CoffeeType)Enum.Parse(typeof(CoffeeType), type);
        int price = (int)Enum.Parse(typeof(CoffeePrice), size);

        if (this.Coins >= price)
        {
            this.Coins = 0;
            this.CoffeesSold.Add(coffee);
        }
    }

    public void InsertCoin(string coin)
    {
        int coins = (int)Enum.Parse(typeof(Coin), coin);

        this.Coins += coins;
    }
}