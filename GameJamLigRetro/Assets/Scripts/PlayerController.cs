using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Camera cam;
    public Weapon Wp;
    public Bullet Bt;

    public float atbValue;
    public float abValue;
    public float sbValue;


    Vector2 movement;
    Vector2 mousePos;

    void Start()
    {
    }


    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");


        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        }

    void FixedUpdate()
    {

        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "SpeedBoost")
        {
            moveSpeed += sbValue;
        }

        if (collision.tag == "AttackSpeedBoost")
        {
            Wp.Cadence -= atbValue;
        }

        if (collision.tag == "AttackBoost")
        {
            Bt.bulletDamage += abValue;
        }




    }
}
