using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise1 : MonoBehaviour
{
    public int sum;
   
    private void Start()
    {
        sum = Operation(5, 10, 15);
        Debug.Log(sum);
    }

    
    private int Operation (int x, int y, int z)
    {
        int result = x + y + z;
        return result / 3;
    }
}
