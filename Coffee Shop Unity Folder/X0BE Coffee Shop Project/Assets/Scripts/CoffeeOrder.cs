using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeOrder : MonoBehaviour
{
    public enum CoffeeType
    {
        Espresso,
        Latte,
        Cappuccino,
        Americano,
        None
    }
    [SerializeField] private CoffeeType coffeeOrder = CoffeeType.Latte;

    void Start()
    {
        switch (coffeeOrder)
        {
            case CoffeeType.Espresso:
                Debug.Log("Making an Espresso.");
                break;
            case CoffeeType.Latte:
                Debug.Log("Making a Latte.");
                break;
            case CoffeeType.Cappuccino:
                Debug.Log("Making a Cappuccino.");
                break;
            case CoffeeType.Americano:
                Debug.Log("Making an Americano.");
                break;
            case CoffeeType.None:
                Debug.Log("No coffee order selected.");
                break;
            default:
                Debug.Log("Sorry we do not have this item in our menu.");
                break;
        }
    }
}
