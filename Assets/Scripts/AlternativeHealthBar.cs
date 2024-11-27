using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlternativeHealthBar : MonoBehaviour
{

    SpriteRenderer mySprite;
    // Start is called before the first frame update
    void Start()
    {
        mySprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.K)) {
        //    mySprite.size += new Vector2(0.01f,0);
        
        //}
    }
}
