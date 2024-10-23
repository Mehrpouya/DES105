using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementWithPhysics : MonoBehaviour
{
    Rigidbody2D BobBody; 
    // Start is called before the first frame update
    void Start()
    {
        SetupVariables();
    }
    void SetupVariables() { 
    BobBody = GetComponent<Rigidbody2D>();
    
    }

    // Update is called once per frame
    void Update()
    {
        CheckPlayerInputs();
    }

    void CheckPlayerInputs() {
        if (Input.GetKeyUp(KeyCode.G)) {
            FlipGravity();
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            BobBody.velocityX += 0.1f;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            BobBody.AddForce(new Vector2(0, 1), ForceMode2D.Impulse);
        }
    }

    void FlipGravity()
    {
        BobBody.gravityScale = -BobBody.gravityScale;
    }
    
}
