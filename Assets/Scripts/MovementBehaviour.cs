using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MovementBehaviour : MonoBehaviour
{
    public float movementSpeed = 0.01f;
    Vector3 movementDirection;
    private Rigidbody2D phyBody;
    PlayerAnimationController myAppearance;
    public TextMeshProUGUI burgerUI;


    int burgerCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        phyBody = GetComponent<Rigidbody2D>();
        myAppearance = GetComponent<PlayerAnimationController>();
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
        movementDirection = Time.deltaTime * movementDirection * movementSpeed ;
        if (movementDirection == Vector3.zero) {

            myAppearance.ChangeAnim("idle");
        }
        else 
        {
            myAppearance.ChangeAnim("Rolling");
        }
        phyBody.AddForce( movementDirection);
    }

    void EatBurger() { 
            burgerCount++;
        burgerUI.text = "Burgers: " + burgerCount;


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.tag);
        if (collision.gameObject.tag.Contains("burger")) {

            print("burger!");
            EatBurger();
        }
    }
}
