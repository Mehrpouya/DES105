using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviour : MonoBehaviour
{
    public float movementSpeed = 0.01f;
    Vector3 movementDirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movementDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.W)) {
            movementDirection = movementDirection +  Vector3.up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            movementDirection = movementDirection + Vector3.down;
        }
        if (Input.GetKey(KeyCode.A))
        {
            movementDirection = movementDirection + Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movementDirection = movementDirection + Vector3.right;
        }
        movementDirection.Normalize();
        movementDirection = movementDirection * movementSpeed;

        transform.position += movementDirection;
    }
}
