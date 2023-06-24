using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaneMovement : MonoBehaviour
{
    public float planeSpeed;
    private float currentAngle = 0f;

    private void Update()
    {
        var targetAngle = Input.GetKey(KeyCode.Space) ? 60f : -80f;
        currentAngle = Mathf.Lerp(currentAngle, targetAngle, Time.deltaTime * 2f);

        transform.rotation = Quaternion.Euler(Vector3.forward * currentAngle);
        transform.Translate(Vector3.right * Time.deltaTime * planeSpeed);

        if(Mathf.Abs(transform.position.y) > 2.4f)
        {
            SceneManager.LoadScene("end");
        }
    }
}
