using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise2 : MonoBehaviour
{
    public string username; //username variable
    public string password; //password variable

    private bool Login (string username, string password)  //Login function
    {
        if (username == "admin" && password == "abccba")
        {
            return true; /*
                           if the password is "abccba" and the username is "admin" returns true
                          */
        }
        else
        {
            return false; /*
                           if the password and the username do not match the correct returns false
                           */
        }
    }
}
