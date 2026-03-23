using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ControlFlow : MonoBehaviour
{
    public float num1 = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 0;
        do
        {
            Debug.Log(i);
            i++;
        }
        while (i < 10);
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.Space))
        {
            num1 += 1;
            Debug.Log("Number is at: " + num1);
            switch (num1)
            {
                case 11:
                    Debug.Log("A");
                    break;

                case 12:
                    Debug.Log("B");
                    break;

                case 13:
                case 15:
                    Debug.Log("C");
                    break;

                default:
                    Debug.Log("Default");
                    break;
            }
            
        }*/
    }
}
