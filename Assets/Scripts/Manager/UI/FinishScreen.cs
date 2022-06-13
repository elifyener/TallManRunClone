using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishScreen : MonoBehaviour
{
    public static FinishScreen Instance;

    public GameObject WinScreen;
    public GameObject LoseScreen;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }
    public void OpenWinScreen()
    {
        WinScreen.SetActive(true);
    }

    public void OpenLoseScreen()
    {
        LoseScreen.SetActive(true);
    }
   
}
