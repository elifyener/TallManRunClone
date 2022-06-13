using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseSystem : MonoBehaviour
{
    private Vector3 tempscale;
    
    private void Update()
    {
        tempscale = gameObject.transform.localScale;
        if ((tempscale.x <= 0 || tempscale.y <= 0 || tempscale.z <= 0) && !WinSystem.passFinish)
        {
            FinishScreen.Instance.OpenLoseScreen();
            TimeSystem.Instance.StopGame();
        }
    }
    
}
