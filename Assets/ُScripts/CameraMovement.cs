using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public float speed;
    public Vector3 offset;
    private void FixedUpdate()
    {
        Vector3 desiredPos = target.position + offset;

        Vector3 deltaPos = Vector3.Lerp(transform.position, desiredPos, speed * Time.deltaTime);

        
        transform.position = new Vector3(deltaPos.x, deltaPos.y, -10f);



    }
}
