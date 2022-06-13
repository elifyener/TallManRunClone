using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SignColliderSystem : MonoBehaviour
{
    GameObject _score;
    string _scoreText;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Height"))
        {
            _score = other.gameObject.transform.parent.gameObject.transform.GetChild (1).gameObject.transform.GetChild (1).gameObject;

            _scoreText = _score.GetComponent<TextMeshProUGUI>().text;

            ScaleChange.Instance.Height(gameObject, _scoreText);
        }
        else if (other.gameObject.CompareTag("Width"))
        {
            _score = other.gameObject.transform.parent.gameObject.transform.GetChild (1).gameObject.transform.GetChild (1).gameObject;

            _scoreText = _score.GetComponent<TextMeshProUGUI>().text;

            ScaleChange.Instance.Width(gameObject, _scoreText);
        }
        else if (other.gameObject.CompareTag("Obstacle"))
        {
            ScaleChange.Instance.Height(gameObject, "-3");
        }       
    }
}
