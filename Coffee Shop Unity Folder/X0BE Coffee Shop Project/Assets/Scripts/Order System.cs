using UnityEngine;

public class OrderSystem : MonoBehaviour
{
    //camel Casing i.e variables
   private float _costOfCoffee = 3.50f;
  
   private int coffeeAmountOrdered;

   public float totalOrderAmount;
    
 //pascal Casing i.e Method, Classes, Properties
   public void AmountPlaced(int coffeeAmountOrdered)
    {
     totalOrderAmount = coffeeAmountOrdered * _costOfCoffee;
     Debug.Log("your Order Amount Today Is"+ "£" + totalOrderAmount);
    }
}
//Acess Modifiers
//void -> private void
//void
//public void -> public void

//if public, can be seen outside of class (script)
//if private, can only be seen outside of class (script)