using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSystem : MonoBehaviour
{
    public static TimeSystem Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }
    public void StartGame()
    {
        Time.timeScale = 1.0f;
    }

    public void StopGame()
    {
        Time.timeScale = 0f;
    }
}
