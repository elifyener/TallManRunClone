using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ScoreBooster : MonoBehaviour
{
    [SerializeField] float _boosterMultiplier;
    int ScoreInt;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ScoreText.Instance._score = (int)(ScoreText.Instance._score * _boosterMultiplier);
            ScoreInt = (int)Math.Ceiling(ScoreText.Instance._score);
            ScoreText.Instance.UpdateScore(ScoreInt);
        }
    }
}
