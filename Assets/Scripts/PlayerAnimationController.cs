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
        
    }

    public void ChangeAnim(string toWhat) {
        if (toWhat == "Idle") {
            StartIdling();
        }
        if (toWhat == "Rolling")
        {
            StartRolling();
        }
        if (toWhat == "Walking")
        {
            StartWalkingAnimation();
        }

    }
    void StartWalkingAnimation() {
        myAnimator.SetBool("is_Rolling", false);
        myAnimator.SetBool("is_Walking", true);
    }
    void StartIdling() {
        myAnimator.SetBool("is_Rolling", false);
        myAnimator.SetBool("is_Walking", false);
    }
    void StartRolling()
    {
        myAnimator.SetBool("is_Rolling", true);
    }

}
