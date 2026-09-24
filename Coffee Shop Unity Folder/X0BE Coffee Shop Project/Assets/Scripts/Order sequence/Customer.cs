using UnityEngine;
using UnityEngine.Events;

public class Customer : MonoBehaviour
{
    public readonly static string drinkType = "Coffee";
    //This is a new keyword that allows us to create a UnityEvent that can be assigned in the inspector
    public string exampleVariable = "Tea";
    public UnityEvent raiseOrder;
    
    void Start()
    {
        RequestDrink(drinkType);
    }
    
    public void RequestDrink(string drinkType)
    {
        Debug.Log(drinkType);
        raiseOrder?.Invoke();
    }
}
