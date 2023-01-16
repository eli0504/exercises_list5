using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise4 : MonoBehaviour
{
    public int[] integers; //array of numbers

    private void Start()
    {
        Debug.Log($"First element = {integers[0]}"); //element 0
        Debug.Log($"Third element = {integers[2]}"); //element 2
        Debug.Log($"Fifth element = {integers[4]}"); //element 4
    }
}
