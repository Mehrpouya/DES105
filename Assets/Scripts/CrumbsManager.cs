using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrumbsManager : MonoBehaviour
{
    public Crumb crumb;
    public List<Crumb> crumbs;
    public Vector3 crumbOffset = new Vector3(0.5f,0,0);
    // Start is called before the first frame update
    void Start()
    {
    }
    public void GenerateCrumbs(int NumberOfCrumbs,Vector3 where) {
        Crumb newCrumb;
        for (int i = 0; i < NumberOfCrumbs; i++) { 
            newCrumb=Instantiate(crumb,where+crumbOffset,Quaternion.identity);
            crumbs.Add(newCrumb);
        }
    }
    // Update is called once per frame
    void Update()
    {
        CleanCrumbs();
    }
    void CleanCrumbs() {
        Crumb crumb = null;
        for (int index = crumbs.Count-1 ; index >=0 ;index--) {
            crumb = crumbs[index];
            if (crumb.isDead) { 
                crumbs.Remove(crumb);
                Destroy(crumb.gameObject);


            }
        }
    }

}
