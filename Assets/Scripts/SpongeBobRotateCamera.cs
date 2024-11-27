using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpongeBobRotateCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.K))
        {
            Camera myCam = Camera.main;
            myCam.transform.Rotate(new Vector3(0, 0, 1), 0.3f);
        }
        if (Input.GetKey(KeyCode.J))
        {
            Camera myCam = Camera.main;
            myCam.transform.Rotate(new Vector3(0, 0, 1), -0.3f);
        }
    }
}
