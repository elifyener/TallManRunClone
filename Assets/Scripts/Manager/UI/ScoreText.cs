using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;

    public static ScoreText Instance;
    public float _score;

    private void Start()
    {
        _score = 0;
    }
    
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    public void UpdateScore(float score)
    {
        _scoreText.text = score.ToString();
    }
}
