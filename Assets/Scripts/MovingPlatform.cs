using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] Vector3 StartPos;
    [SerializeField] Vector3 EndPos;
    [SerializeField] float PlatformSpeed = 0.01f;
    Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        target = StartPos;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, PlatformSpeed);
        if (Vector3.Distance(transform.position, target) <= 0.05) {
            if (target == StartPos) { target = EndPos; }
            else { target = StartPos; }
        }
    }
}
