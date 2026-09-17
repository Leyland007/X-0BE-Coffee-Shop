using UnityEngine;
//This is script A
public class ClickDetector : MonoBehaviour

{
    //Every frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
           //This is tagged "MainCamera" in the inspector
           if (Physics.Raycast(ray, out RaycastHit hit))
           {
               IClickable clickable = hit.collider.GetComponent<IClickable>();

               clickable?.OnClick();
               //calls the interface "IClickable"
           }
        }
    }
}
