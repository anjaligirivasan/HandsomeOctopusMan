using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    public CamFollow cameraFollow;
    public Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        cameraFollow.Setup(() => playerTransform.position);
    }
}
