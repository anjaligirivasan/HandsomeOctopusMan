using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Camera mainC;
    public Vector3 offset;

    // Update is called once per frame
    void FixedUpdate()
    {
        // if you remove offset then it is centered, if you keep offset then player is in the corner
        mainC.transform.position = new Vector3(player.transform.position.x + offset.x,
            player.transform.position.y + offset.y, mainC.transform.position.z + offset.z);
    }
}
