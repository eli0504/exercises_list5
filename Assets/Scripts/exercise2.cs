using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise2 : MonoBehaviour
{
    public string username;
    public string password;

    public bool login;

    private void Start()
    {
        bool login = Login("admin", "abccba");

        if (Login("admin", "abccba"))
        {
            Debug.Log(true);
            
        }
        else
        {
            Debug.Log(false);
        }

        Debug.Log(login);
    }

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
