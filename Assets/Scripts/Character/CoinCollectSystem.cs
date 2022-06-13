using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollectSystem : MonoBehaviour
{
    [SerializeField] float _increaseAmount;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            ScoreText.Instance._score += _increaseAmount;
            ScoreText.Instance.UpdateScore(ScoreText.Instance._score);
            Destroy(other.gameObject);
        }
    }
    
}
