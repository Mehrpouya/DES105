using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    Animator myAnimator;
    string myAnimationState = "idle";
    // Start is called before the first frame update
    void Start()
    {
        initialiseVariables();
    }

    void initialiseVariables() { 
        myAnimator = GetComponent<Animator>();
    }

    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K)) {
            bool is_Rolling = myAnimator.GetBool("is_Rolling");
            myAnimator.SetBool("is_Rolling", !is_Rolling);
        }   
    }

    public void ChangeAnim(string toWhat) {
        if (toWhat == "idle") {
            StartIdling();
        }
        if (toWhat == "Rolling")
        {
            StartRolling();
        }

    }

    void StartIdling() {
        myAnimator.SetBool("is_Rolling", false);
        myAnimator.SetInteger("xMovement", 0);
    }
    void StartRolling()
    {
        myAnimator.SetBool("is_Rolling", true);
        myAnimator.SetInteger("xMovement", 0);
    }

}
