using UnityEngine;

public class CoffeeMachine : MonoBehaviour
{
    bool coffeeBeansAvailable = false;

void Start()
{
    if(coffeeBeansAvailable)
    {
       Debug.Log("Coffee brewing started.");
    }
    else
    {
       Debug.Log("No coffee beans available. Please refill.");
    }
}
}