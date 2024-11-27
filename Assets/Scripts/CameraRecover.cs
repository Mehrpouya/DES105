using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class CameraRecover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.rotation.z != 0)
        {
            RevertAngle();
        }
    }
    //You can either define variables at the beginning of your class or between functions like below
    //You can change this from Unity Editor as it is defined using SerializeField
    [SerializeField] float RecoverySpeed = 0.005f;
    void RevertAngle() {
        if (transform.rotation.z < 0)
        {
            transform.Rotate(new Vector3(0, 0, 1), RecoverySpeed);
        }
        else {
            transform.Rotate(new Vector3(0, 0, 1), -RecoverySpeed);
        }
    }
}
