using UnityEngine;

public class GenericClasses : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        // Declare variables
        GenericClass<string> instanceString = new GenericClass<string>();

        instanceString.Print("Hello World!");
    }
}

public class GenericClass<T>
{
    // Output the data
    public void Print(T data)
    {
        Debug.LogFormat("Type: {0} | Value: {1}", typeof(T).ToString(), data);
    }
}