using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dosnumeros : MonoBehaviour
{
    public string num1;
    public string num2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(num1 == num2)
        {
            Debug.Log("Los numeros son iguales");
        }
        else
        {
            Debug.Log("Los numeros no son iguales");
        }
    }
}
