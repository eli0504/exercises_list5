using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise3 : MonoBehaviour
{
    public int clickCounter; //variable for click

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) //when you click "A" adds one to a counter
        {
            AddOneToCounter();
        }

        if (clickCounter == 10) /*
                                 if the counter is equal to 10, it is game over
                                 */
        {
            Debug.Log("¡GAME OVER!");

        }
    }

    private void AddOneToCounter()
    {
        clickCounter++; // adds one to a counter
    }
}
