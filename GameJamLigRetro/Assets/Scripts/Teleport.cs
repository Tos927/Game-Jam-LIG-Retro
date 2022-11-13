using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField]
    private BoxCollider2D bc;
    public Transform tpPoint;

    private void Start()
    {
        bc = GetComponent<BoxCollider2D>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("Hit");
            collision.transform.position = tpPoint.position;
        }
    }

}
