
//This is script B
using UnityEngine;
using UnityEngine.Events;

public class ClickableObject : MonoBehaviour, IClickable
{
    [SerializeField] private UnityEvent onClick;

    public void OnClick()
    {
        onClick?.Invoke();
        Debug.Log("Found clickable object");
    }
    
}
