using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float rotateAmount;

    private Vector3 dir = Vector3.left;

    //Your Update function
    void Update()
    {
        transform.Translate(dir * moveSpeed * Time.deltaTime);
        transform.Rotate(1, rotateAmount * Time.deltaTime, 0);
        ChangeSpin();
        // call the method
 
        if (transform.position.x <= -4)
        {
            dir = Vector3.right;
        }
        else if (transform.position.x >= 4)
        {
            dir = Vector3.left;
        }
    }
    public void ChangeSpin()
    {
        rotateAmount = -rotateAmount;  // you might want to fix this otherwise it'd look like it's twitching
    }
}
