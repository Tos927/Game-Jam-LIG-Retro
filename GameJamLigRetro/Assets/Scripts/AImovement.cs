using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AImovement : MonoBehaviour
{
    
    private bool isFacingRight;
    private bool isFacingLeft;
    private bool isFacingTop;
    private bool isFacingDown;

    public Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.velocity.x > 0 && Mathf.Abs(rb.velocity.x) > Mathf.Abs(rb.velocity.y))
        {
            rb.rotation = 90;
        }
        if(rb.velocity.x < 0 && Mathf.Abs(rb.velocity.x) > Mathf.Abs(rb.velocity.y))
        {
            rb.rotation = 270;
        }
        if(rb.velocity.y > 0 && Mathf.Abs(rb.velocity.y) > Mathf.Abs(rb.velocity.x))
        {
            rb.rotation = 180;
        }
        if(rb.velocity.y < 0 && Mathf.Abs(rb.velocity.y) > Mathf.Abs(rb.velocity.x))
        {
            rb.rotation = 0;
        }
        
    }

    


}
