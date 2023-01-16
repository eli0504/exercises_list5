using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise5 : MonoBehaviour
{
    public int[] integers; //array of numbers

    private void Start()
    {
        
         if (integers.Length >= 5) //array size
        {
            Debug.Log($"First element = {integers[0]}");
            Debug.Log($"Third element = {integers[2]}");
            Debug.Log($"Fifth element = {integers[4]}");
        }
        else
        {
            Debug.Log("Missing elements"); 
        }
    }

    
}
