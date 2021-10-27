using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    // Cached component
    public Rigidbody2D rb;
    public Camera cam;
    Vector2 mousePos;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    { 
        // player movement
        if(Input.GetKey(KeyCode.UpArrow))
        {
            //print("up key was pressed");
            rb.velocity = new Vector2(0.0f, 4.0f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
           //print("down key was pressed");
            rb.velocity = new Vector2(0.0f, -4.0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //print("right key was pressed");
            rb.velocity = new Vector2(4.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //print("left key was pressed");
            rb.velocity = new Vector2(-4.0f, 0.0f);
        }

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        Vector2 lookDirection = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x)* Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}
