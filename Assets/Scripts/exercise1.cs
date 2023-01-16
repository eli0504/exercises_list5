using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise1 : MonoBehaviour
{
    public int sum; //variable
    
    private int Operation (int x, int y, int z) //operation function 
    {
        int result = x + y + z;
        return result / 3; //returns the total result
    }
}
