using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visibility : MonoBehaviour
{
    public SpriteRenderer vis; // drag attached script object sprite renderer onto this in inspector to control visibility


    // Start is called before the first frame update
    void Start()
    {
        vis = this.GetComponent<SpriteRenderer>(); //technically unnecesary, but just ensures sprite renderer is selected
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Space)) //if player presses space, toggle the visibility of the attached object on or off
        {
            vis.enabled = !vis.enabled;
        }
    }
}
