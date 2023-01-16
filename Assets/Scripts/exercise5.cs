using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise5 : MonoBehaviour
{
    public int[] integers;

    private void Start()
    {
        Debug.Log($"First element = {integers[0]}");
        Debug.Log($"Third element = {integers[2]}");
        Debug.Log($"Fifth element = {integers[4]}");

        
    }

    
}
