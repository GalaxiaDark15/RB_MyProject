using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefExample : MonoBehaviour
{
    private void Start()
    {
        int value = PlayerPrefs.GetInt("timesUserLoggedIn", 0);

        if (value == 0)
        {
            Debug.Log("First Time Playing The Game");
        }
        else
        {
            Debug.Log($"Welcome back! You have played {value} times!");
        }

        PlayerPrefs.SetInt("timesUserLoggedIn", value + 1);
    }
}
