using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform plane;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(plane.position.x + 2.5f, 0f, -10f);    
    }
}
