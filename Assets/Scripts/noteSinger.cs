using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteSinger : MonoBehaviour
{
    AudioSource myVoice;
    Rigidbody2D myBody;
    public AudioClip[] myListOfVoices;

    public int lifeSpan = 0;
    int heartBeat = 0;
    // Start is called before the first frame update
    void Start()
    {
        myVoice = GetComponent<AudioSource>();
        myBody = GetComponent<Rigidbody2D>();
        lifeSpan = Random.Range(500,1500);
    }

    // Update is called once per frame
    void Update()
    {

        //CheckInputs();
        CheckLifeSpan();
        print("random valuye is: " + Random.Range(0, 100));
    }

    void CheckLifeSpan() {

        heartBeat= heartBeat+ 1 ;
        if (heartBeat>=lifeSpan) {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D whoDidIBump)
    {
        Random.InitState(heartBeat);
        float randX = Random.Range(-30f, 30f);
        float randY = Random.Range(-30, 30);
        Vector2 randomForce = new Vector2(randX, randY);
        ChangeMyVoice();
        myBody.AddForce(randomForce,ForceMode2D.Impulse);
        if (whoDidIBump.gameObject.name.Contains("wall"))   {
            myVoice.pitch = Random.Range(0.7f, 1.3f);
            myVoice.Play();
        }
    }

    void ChangeMyVoice() {
    myVoice.clip = myListOfVoices[Random.Range(0,myListOfVoices.Length)];   
    
    }
    void CheckInputs() {
        if (Input.GetMouseButtonDown(0)) { 
            myVoice.pitch= Random.Range(0.7f, 1.3f);
            myVoice.Play();
        }
    
    }
}
