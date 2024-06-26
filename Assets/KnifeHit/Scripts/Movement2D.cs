//System
using System.Collections;
using System.Collections.Generic;

//UnityEngine
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;

    private Vector3 moveDirection = Vector3.up;

    private void Update()
    {
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }

    public void MoveTo(Vector3 dir)
    {
        moveDirection = dir;
    }
}
