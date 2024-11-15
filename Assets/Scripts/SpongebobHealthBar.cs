using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpongebobHealthBar : MonoBehaviour
{
    Image healthBar;
    float healthAmount = 1;

    // Start is called before the first frame update
    void Start()
    {
        initialiseVariables();
        
    }
    void initialiseVariables() {

        healthBar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount -= 0.001f;

        if (Input.GetKey(KeyCode.K)){
            healthBar.fillAmount += 0.001f;
        }
        if (Input.GetKeyUp(KeyCode.C))
        {
            healthBar.fillMethod = Image.FillMethod.Vertical;
        }

    }
}
