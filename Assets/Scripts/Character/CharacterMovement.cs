using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float xSpeed;
    [SerializeField] float moveLimitX;

    Touch _touch;
    Vector3 _touchDown;
    Vector3 _touchUp;

    bool _dragStarted;
    bool _isMoving;

    private void Start()
    {
        TimeSystem.Instance.StopGame();
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {   
            StartScreen.Instance.CloseStartText();
            TimeSystem.Instance.StartGame();
            _touch = Input.GetTouch(0);
            if (_touch.phase == TouchPhase.Began)
            {
                _dragStarted = true;
                _touchDown = _touch.position;
                _touchUp = _touch.position;
            }
            if (_dragStarted)
            {
                if (_touch.phase == TouchPhase.Moved)
                {
                    _touchDown = _touch.position;
                }
                if (_touch.phase == TouchPhase.Ended)
                {
                    _touchDown = _touch.position;
                    _dragStarted = false;
                }
                
            transform.position = Vector3.MoveTowards(transform.position, CalculateDirection(), xSpeed * Time.deltaTime);
            }
        }

        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
    }

    Vector3 CalculateDirection()
    {
        Vector3 temp = (_touchDown - _touchUp).normalized * moveLimitX;

        temp.z = transform.position.z;
        temp.y = transform.position.y;
        
        return temp;
    }

}
