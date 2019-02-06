using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    private Vector3 offset = new Vector3(0, 0, -5);
    private Vector3 targetPos;
    private float minPosition = -2f;
    private float maxPosition = 4f;
 
    void Start()
    {
        transform.position = player.transform.position + offset;
    }

    void FixedUpdate()
    {
        targetPos = player.position + offset;
        targetPos = new Vector3(Mathf.Clamp(player.transform.position.x, minPosition, maxPosition), transform.position.y, transform.position.z);
        //smoothedPos = Vector3.Lerp(transform.position, playerPos, smoothLevel);
        transform.position = targetPos;
    }
}
