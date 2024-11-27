using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbsorbingThings : MonoBehaviour
{
    CrumbsManager crumbsManager;
    // Start is called before the first frame update
    void Start()
    {
        crumbsManager = GameObject.Find("CrumbsManager").GetComponent<CrumbsManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("burger")) {
            crumbsManager.GenerateCrumbs(100, 
                transform.position );
        } 
    }
 }

