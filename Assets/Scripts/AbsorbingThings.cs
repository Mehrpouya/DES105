using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
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
            ReduceTint();
        } 
    }
    void ReduceTint() {
       GameObject tint = GameObject.Find("CameraTint");
       SpriteRenderer tintSprite = tint.GetComponent<SpriteRenderer>();
        Color tintColor = new Color(tintSprite.color.r,
                                     tintSprite.color.g,
                                     tintSprite.color.b,
                                     tintSprite.color.a / 5.0f);
        tintSprite.color = tintColor;
    }
}
 

