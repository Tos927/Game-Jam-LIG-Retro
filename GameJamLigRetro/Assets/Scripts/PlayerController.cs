using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private float rotationSpeed = 720f;
    public Rigidbody2D rb;
    public Camera cam;
    public Weapon Wp;
    public Bullet Bt;


    void Start()
    {
    }


    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");


        Vector2 movementDirection = new Vector2(horizontalInput, verticalInput);
        float inputMagnitude = Mathf.Clamp01(movementDirection.magnitude);
        movementDirection.Normalize();

        transform.Translate(movementDirection*moveSpeed*inputMagnitude*Time.deltaTime, Space.World);

        if (movementDirection!=Vector2.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movementDirection);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }

    void FixedUpdate()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "SpeedBoost")
        {
            moveSpeed++;
        }

        if (collision.tag == "AttackSpeedBoost")
        {
            Wp.Cadence -= 0.5f;
        }

        if (collision.tag == "AttackBoost")
        {
            Bt.Damage += 0.5f;
        }




    }
}
