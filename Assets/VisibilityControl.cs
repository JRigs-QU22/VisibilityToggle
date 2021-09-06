using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibilityControl : MonoBehaviour
{
    GameObject[] Set1;
    GameObject[] Set2;

    public bool Set1Vis;
    
    // Start is called before the first frame update
    void Start()
    {
        Set1 = GameObject.FindGameObjectsWithTag("Set1");
        Set2 = GameObject.FindGameObjectsWithTag("Set2");
        Set1Vis = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (Set1Vis == true)
        {
            foreach(GameObject r in Set1)
            {
                r.gameObject.GetComponent<SpriteRenderer>().enabled = true;
            }
            foreach (GameObject r in Set2)
            {
                r.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            }
            if (Input.GetKey(KeyCode.Space))
            {
                Set1Vis = false;
            }
        }
       else if (Set1Vis == false)
        {
            foreach (GameObject r in Set1)
            {
                r.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            }
            foreach (GameObject r in Set2)
            {
                r.gameObject.GetComponent<SpriteRenderer>().enabled = true;
            }
            if (Input.GetKey(KeyCode.Space))
            {
                Set1Vis = true;
            }
        }
        
    }
}
