using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class normalAI : MonoBehaviour
{
    
    private Transform target;

    public LayerMask icecreamMachine;
    public float normalHeatlh;
    
    public float speed;
    public float nextWaypointDistance;

    Path path;
    int currentWaypoint = 0;
    bool reachedEndOfPath = false;

    private Seeker seeker;
    private Rigidbody2D rb;
    private Collider2D col;


    // Start is called before the first frame update
    void Start()
    {
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<BoxCollider2D>();
        target = GameObject.FindGameObjectWithTag("Target").transform;

        seeker.StartPath(rb.position, target.position, OnPathComplete);
    }

    void OnPathComplete(Path p)
    {
        if(!p.error)
        {
            path = p;
            currentWaypoint = 0;
        }
    }


    void Update()
    {
        if(col.IsTouchingLayers(icecreamMachine)){
            Destroy(gameObject);
        }
    }


    void FixedUpdate()
    {
        if(path == null){
            return;
        }

        if(currentWaypoint >= path.vectorPath.Count)
        {
            reachedEndOfPath = true;
            return;
        }else
        {
            reachedEndOfPath = false;
        }


        Vector2 direction = ((Vector2)path.vectorPath[currentWaypoint] - rb.position).normalized;
        Vector2 force =  direction * speed * Time.deltaTime;

        rb.AddForce(force);
        
        float distance = Vector2.Distance(rb.position, path.vectorPath[currentWaypoint]);

        if(distance < nextWaypointDistance)
        {
            currentWaypoint ++;
        }

    }
}
