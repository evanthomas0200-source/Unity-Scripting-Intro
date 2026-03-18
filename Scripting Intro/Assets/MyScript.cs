using UnityEngine;

public class MyScript : MonoBehaviour
{
    public int my_int = 15;
    public float my_float = 1.5f;
    public char my_char = 'c';
    public string my_string = "C is a letter";
    public Vector2 my_vec2 = new Vector2(12, 8);
    public Vector3 my_vec3 = new Vector3(4.6f, 10.2f, 13.5f);
    public int[] my_array = { 1, 3, 5, 7, 9, 11, 13, 15 };
    private float[] my_array2 = { 2.0f, 4.0f, 6.0f, 8.0f, 10.0f };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(Add(10, -9));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }
}
