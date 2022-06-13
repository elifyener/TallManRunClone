using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreen : MonoBehaviour
{
    public static StartScreen Instance;

    public GameObject StartText;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }
    public void CloseStartText()
    {
        StartText.SetActive(false);
    }
}
