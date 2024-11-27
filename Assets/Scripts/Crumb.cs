using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crumb : MonoBehaviour
{
    public float MovementSpeed=0.2f;
    public int age = 0;
    public int MaxAge=100;
    public bool isDead=false;
    Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        SetupVariables();
    }
    void SetupVariables() {
        MovementSpeed = Random.Range(-0.05f,0.05f);
        MaxAge = Random.Range(50, 300);
        direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
        direction.Normalize();
    }
    // Update is called once per frame
    void Update()
    {
        CheckAge();
        if (age % 5 == 0) {
            ChooseNewDirection();
        }
        MoveParticle();
    }

    void ChooseNewDirection() {
        direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f);
        direction.Normalize();
    }
    void MoveParticle() {
        transform.position += direction * MovementSpeed;
    
    }
    void CheckAge() {
        age++;
        if (age >= MaxAge) { 
           isDead = true;
        }
    }
}
