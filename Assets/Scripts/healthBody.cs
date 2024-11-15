using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class healthBody : MonoBehaviour
{
    SpriteRenderer playerSprite;
    // Start is called before the first frame update
    void Start()
    {
        playerSprite = GetComponent<SpriteRenderer>();
    }


    // Update is called once per frame
    void Update()
    {
        playerSprite.size -= new Vector2(0.001f, 0.0f);

        if (Input.GetKey(KeyCode.Space)) {
            playerSprite.size += new Vector2(0.002f, 0.0f);
        }
    }

}
