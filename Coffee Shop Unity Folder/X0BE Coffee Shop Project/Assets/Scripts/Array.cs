using UnityEngine;
using System.Collections;
public class NewEmptyCSharpScript : MonoBehaviour
{
     // Exposes an float array in the inspector, which you can edit there.
    public float[] values;
    void Start()
    {
        foreach (float value in values)
        {
            print(value);
        }

        // Since we can't resize builtin arrays
        // we have to recreate the array to resize it
        values = new float[10];

        // assign the second element
        values[1] = 5.0F;
    }
}
