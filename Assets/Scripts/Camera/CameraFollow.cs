using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector3 offset;
    private void LateUpdate()
    {
        transform.position =  Vector3.Lerp(transform.position, target.position + offset, Time.deltaTime * 2);
    }
}
