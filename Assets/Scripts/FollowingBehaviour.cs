using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class FollowingBehaviour : MonoBehaviour
{
    public GameObject WhoToFollow;
    public float followingSpeed = 0.1f;
    public float distanceTrigger = 1.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, WhoToFollow.transform.position);
        if (distance <= distanceTrigger)
        {
            transform.position = Vector3.MoveTowards(transform.position, 
                                                    WhoToFollow.transform.position, 
                                                    followingSpeed);
        }
    }
}
