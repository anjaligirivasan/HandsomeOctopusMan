using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject playerCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        // player movement
        if(Input.GetKey(KeyCode.UpArrow))
        {
            print("up key was pressed");
            transform.Translate(0, 0.1f, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            print("down key was pressed");
            transform.Translate(0, -0.1f, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            print("right key was pressed");
            transform.Translate(0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            print("left key was pressed");
            transform.Translate(-0.1f, 0, 0);
        }

        // to shoot ink
        if (Input.GetKey(KeyCode.Space))
        {
            print("space key was pressed");
        }
    }
}
