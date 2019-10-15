using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    private void Start()
    {
        
    }

    private void FixedUpdate()
    {
        Vector3 desiredPosition = new Vector3(
            Mathf.Clamp(target.position.x +offset.x,0.0f,26.0f),
            Mathf.Clamp(target.position.y + offset.y,0f,4f),
            target.position.z + offset.z
            );
        //Vector3 desiredPosition = targetPosition + offset;

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        
        transform.position = smoothedPosition;

    }

}
