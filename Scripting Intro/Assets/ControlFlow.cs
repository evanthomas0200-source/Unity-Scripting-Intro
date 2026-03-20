using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ControlFlow : MonoBehaviour
{
    public float num1 = 10;
    public float num2 = 2;
    public float num3 = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            num1 += 1;
            Debug.Log("Number is at: " + num1);
            if (num1 % 2 == 0)
            {
                Debug.Log(num1 + "Is even...");
            }
            else
            {
                Debug.Log(num1 + "Is odd...");
            }
        }
    }
}
