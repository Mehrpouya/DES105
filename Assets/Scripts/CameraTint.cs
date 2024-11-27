using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTint : MonoBehaviour
{
    GameObject tint;
    SpriteRenderer tintSprite;
    [SerializeField] Color tintColor;
    // Start is called before the first frame update
    void Start()
    {
        tintSprite = GetComponent<SpriteRenderer>();
        tintSprite.color = tintColor;
    }

    // Update is called once per frame
    void Update()
    {
        tintColor = tintSprite.color;
        tintColor = new Color(tintColor.r, tintColor.g, tintColor.b, tintColor.a + 0.0001f);
        tintSprite.color = tintColor;
    }
}
