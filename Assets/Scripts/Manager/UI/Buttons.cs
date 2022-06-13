using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void OnNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void OnRestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void OnExitGame()
    {
        StartCoroutine(ExitDelay());
        Application.Quit();
    }

    IEnumerator ExitDelay()
    {
        yield return new WaitForSeconds(0.5f);
    }
}
