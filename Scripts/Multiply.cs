using UnityEngine;

public class Multiply : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        /*string resultString = "";*/
        int resultMultiply = 0;
        for (int i = 1; i < 11; i++)
        {
            resultMultiply = multiply(5,i);

            Debug.Log("5 x "+i + " = " + resultMultiply);

        }
        
    }

    int multiply(int x1 , int x2) { 
    
        return x1 * x2;
    }
}
