using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Productos : MonoBehaviour
{
    public int p1;
    public int p2;
    public int p3;
    public int dinero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int total = p1 + p2 + p3;
        if (total > dinero) {
            Debug.Log("No alcanza el dinero");
        }
        else
        {
            Debug.Log("El dinero alcanza");
        }
    }
}
