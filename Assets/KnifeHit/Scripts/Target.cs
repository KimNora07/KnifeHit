//System
using System.Collections;
using System.Collections.Generic;

//UnityEngine
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField]
    private float rotateSpeed;

    private Vector3 rotateAngle = Vector3.forward;

    private void Update()
    {
        transform.Rotate(rotateAngle * rotateSpeed * Time.deltaTime);
    }
}
