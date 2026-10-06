using UnityEngine;

public class CoffeeMenu : MonoBehaviour
{
    private string[] coffeeMenu = { "Espresso", "Latte", "Cappuccino", "Americano", "Mocha" };

    void Start()
    {
        foreach (string coffee in coffeeMenu)
        {
            Debug.Log("Now Serving: " + coffee);
        }
    }
}
