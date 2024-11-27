using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject movingPlatform;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AddChallenge());
    }
    IEnumerator AddChallenge()
    {
        for (; ; )
        {
            GameObject newPlatform = Instantiate(movingPlatform);
            MovingPlatform movingScript = newPlatform.GetComponent<MovingPlatform>();
            movingScript.ChooseRandomStarEnd();
            yield return new WaitForSeconds(3f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
