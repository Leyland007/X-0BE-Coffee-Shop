using UnityEngine;

public class SugarLevel : MonoBehaviour
{
    int sugarLevel = 2;

void Start()
{
    if (sugarLevel == 1)
    {
        Debug.Log("Coffee with 1 teaspoon of sugar.");
    }
    else if (sugarLevel == 2)
    {
        Debug.Log("Coffee with 2 teaspoons of sugar.");
    }
    else if (sugarLevel == 3)
    {
        Debug.Log("Coffee with 3 teaspoons of sugar.");
    }
    else
    {
        Debug.Log("Black Coffee, with no sugar.");
    }
}
}