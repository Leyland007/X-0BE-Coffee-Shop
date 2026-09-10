using UnityEngine;

public class CoffeeShopTest : MonoBehaviour
{
    public int amountOrdered = 5;
    public int coffeesSold = 0;
    public float coffeePrice = 3.50f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      Debug.Log("Hello!");
      Debug.Log("I would like to order");
      Debug.Log(amountOrdered + " coffees");
      amountOrdered++;  
      Debug.Log("Coffees sold: " + coffeesSold);
      Debug.Log("Oops, I actually want to order " + amountOrdered + " coffees");

      amountOrdered = amountOrdered * 5;
      Debug.Log(amountOrdered);  
    }

void addCoffee()
    {
        coffeesSold += 1;
    }
   
}
