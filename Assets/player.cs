using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    // Cached component
    private Rigidbody2D rb;

    //private float t = 0.0f;
    //private bool moving = false;

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
            print("up key was pressed");
            rb.velocity = new Vector2(0.0f, 4.0f);
            //moving = true;
            //t = 0.0f;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            print("down key was pressed");
            rb.velocity = new Vector2(0.0f, -4.0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            print("right key was pressed");
            rb.velocity = new Vector2(4.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            print("left key was pressed");
            rb.velocity = new Vector2(-4.0f, 0.0f);
        }

        // to shoot ink
        if (Input.GetKey(KeyCode.Space))
        {
            print("space key was pressed");
        }
    }
}
