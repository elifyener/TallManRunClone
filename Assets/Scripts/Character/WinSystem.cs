using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinSystem : MonoBehaviour
{
    [SerializeField] float _delayTime;
    private Vector3 tempscale;
    public static bool passFinish;

    private void Start()
    {
        passFinish = false;   
    }

    private void Update()
    {
        tempscale = gameObject.transform.localScale;
        if ((tempscale.x <= 0 || tempscale.y <= 0 || tempscale.z <= 0) && passFinish)
        {
            FinishScreen.Instance.OpenWinScreen();
            TimeSystem.Instance.StopGame();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("FinishPoint"))
        {
            passFinish = true;
            tempscale = gameObject.transform.localScale;
            ParticleSystemManager.Instance.PlayWinParticleSystem();
            StartCoroutine(FinishDelay());
        }          
    }

    IEnumerator FinishDelay()
    {
        yield return new WaitForSeconds(_delayTime);
        FinishScreen.Instance.OpenWinScreen();
        TimeSystem.Instance.StopGame();
    }
}
