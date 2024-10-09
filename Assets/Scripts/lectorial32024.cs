using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lectorial32024 : MonoBehaviour
{
    public string username = "hadi";
    int hadi = new int();


    // Start is called before the first frame update
    void Start()
    {

        specialUsermove();
        print("welcome: " + username);

        username = "unknown user!";
        
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("k"))
        {
            specialUsermove();
        }
    }

    void specialUsermove() {
        if (username.Contains("hadi"))
        {
            transform.Translate(Vector2.left * 10 *Time.deltaTime);

        }
    }
}
