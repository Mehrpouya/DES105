using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceGod : MonoBehaviour
{
    public GameObject[] soundObjects;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {

            Instantiate(soundObjects[
                Random.Range(0, soundObjects.Length)],
                new Vector3(Random.Range(-4f,4f), 
                Random.Range(-4f, 4f),
                0),Quaternion.identity);    
        }
    }
}
