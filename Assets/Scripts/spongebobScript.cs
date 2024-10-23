using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spongebobScript : MonoBehaviour
{
    SpriteRenderer spongebob_Renderer;

    public GameObject leftSpinner;
    public GameObject rightSpinner;

    public float distanceTrigger = 1;
   
    // Start is called before the first frame update
    void Start()
    {
        prepeSpongebob();
    }

    void prepeSpongebob() {
        spongebob_Renderer = GetComponent<SpriteRenderer>();
    }

    void flipSpongebob() {

        spongebob_Renderer.flipX = !spongebob_Renderer.flipX;
    }

    // Update is called once per frame
    void Update()
    {
        CheckInputs();
        CheckDistanceToSpinners();
    }

    void CheckDistanceToSpinners() {
        /*check distance with right spinner
         * if ddistance is less than threshhold, spin Spongebob 
        */
        //Check distance with left spinner

        float distance = Vector3.Distance(transform.position, rightSpinner.transform.position);
        if (distance < distanceTrigger) {
            //spin spongebob here
            transform.Rotate(new Vector3(0, 0, 1), 1);
           spongebob_Renderer.color = Color.red;    
            //Send a message to the right spinner
            FollowingBehaviour rFollowBehave = rightSpinner.GetComponent<FollowingBehaviour>();
            if (rFollowBehave != null) {
                rFollowBehave.HearAMessage("Hi, I'm close to the right spinner", "SpongeBob");
            }
        }
        distance = Vector3.Distance(transform.position, leftSpinner.transform.position);
        if (distance < distanceTrigger)
        {
            //spin spongebob here
            transform.Rotate(new Vector3(0, 0, 1), -1);
        }

    }
    void CheckInputs() {
        if (Input.GetKey(KeyCode.F))
        {
            flipSpongebob();
        }
    
    }

}
