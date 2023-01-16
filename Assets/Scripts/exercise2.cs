using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise2 : MonoBehaviour
{
    public string username;
    public string password;

    private bool Login (string username, string password)
    {
        if (username == "admin" && password == "abccba")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
