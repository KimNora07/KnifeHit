//System
using System.Collections;
using System.Collections.Generic;

//UnityEngine
using UnityEngine;

public class Pin : MonoBehaviour
{
    [SerializeField]
    private GameObject knife;
    [SerializeField]
    private GameObject handle;

    private Movement2D movement2D;

    private BoxCollider2D boxCollider;
    private CircleCollider2D circleCollider;

    private void Start()
    {
        movement2D = GetComponent<Movement2D>();
        boxCollider = GetComponent<BoxCollider2D>();
        circleCollider = GetComponent<CircleCollider2D>();

        boxCollider.enabled = true;
        circleCollider.enabled = false;

        this.gameObject.tag = "Pin";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (this.gameObject.CompareTag("Pin"))
        {
            if (collision.gameObject.CompareTag("Target"))
            {
                movement2D.MoveTo(Vector3.zero);
                transform.SetParent(collision.transform);

                boxCollider.enabled = false;
                circleCollider.enabled = true;

                this.gameObject.tag = "ShottedPin";

                Destroy(this);
            }

            if (collision.gameObject.CompareTag("ShottedPin"))
            {
                Debug.Log("���� ����");
            }
        }

        
        // �߻��� ���� �պκ��� �̹� ���� ���� �޺κп� ����� ���
        // ���� ����
    }
}
