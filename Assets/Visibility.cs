using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visibility : MonoBehaviour
{
    public SpriteRenderer vis;


    // Start is called before the first frame update
    void Start()
    {
        vis = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            vis.enabled = !vis.enabled;
        }
    }
}
