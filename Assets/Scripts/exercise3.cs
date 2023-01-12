using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise3 : MonoBehaviour
{
    public int clickCounter;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            AddOneToCounter();
        }

        if (clickCounter == 10)
        {
            Debug.Log("¡GAME OVER!");

        }
    }

    private void AddOneToCounter()
    {
        clickCounter++;
    }
}
