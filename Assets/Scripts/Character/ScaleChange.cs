using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChange : MonoBehaviour
{
    public static ScaleChange Instance;

    private Vector3 tempscale;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    public void Height(GameObject gameObject, string score)
    {
        tempscale = gameObject.transform.localScale;
        switch (score[0])
        {
            case '+':
                score = score.Remove(0, 1);
                tempscale.y += Int16.Parse(score) * 0.05f;
            break;

            case '-':
                score = score.Remove(0, 1);
                tempscale.y -= Int16.Parse(score) * 0.05f;
            break;

            case 'x':
                score = score.Remove(0, 1);
                tempscale.y *= Int16.Parse(score) * 0.05f;
            break;

            case '/':
                score = score.Remove(0, 1);
                tempscale.y /= Int16.Parse(score) * 0.05f;
            break;
        }
        
        gameObject.transform.localScale = tempscale;
    }

    public void Width(GameObject gameObject, string score)
    {
        tempscale = gameObject.transform.localScale;
        switch (score[0])
        {
            case '+':
                score = score.Remove(0, 1);
                tempscale.x += Int16.Parse(score) * 0.05f;
                tempscale.z += Int16.Parse(score) * 0.05f;
            break;

            case '-':
                score = score.Remove(0, 1);
                tempscale.x -= Int16.Parse(score) * 0.05f;
                tempscale.z -= Int16.Parse(score) * 0.05f;
            break;

            case 'x':
                score = score.Remove(0, 1);
                tempscale.x *= Int16.Parse(score) * 0.05f;
                tempscale.z *= Int16.Parse(score) * 0.05f;
            break;

            case '/':
                score = score.Remove(0, 1);
                tempscale.x /= Int16.Parse(score) * 0.05f;
                tempscale.z /= Int16.Parse(score) * 0.05f;
            break;
        }
        
        gameObject.transform.localScale = tempscale;
    }
    
}
