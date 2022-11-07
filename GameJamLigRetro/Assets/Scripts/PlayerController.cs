using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Camera cam;
    //public Weapon Wp;
    //public Bullet Bt;


    Vector2 movement;
    Vector2 mousePos;

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
            moveSpeed++;
        }

        if (collision.tag == "AttackSpeedBoost")
        {
            //Wp.Cadence -= 0.5f;
        }

        if (collision.tag == "AttackBoost")
        {
            Debug.Log("Yes");
            //Bt.Damage += 0.5f;
        }




    }
}
