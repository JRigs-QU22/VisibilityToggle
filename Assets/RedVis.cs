using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedVis : MonoBehaviour
{
    public SpriteRenderer vis; //spriterenderer of attached object (left public for debugging purposes

    // Start is called before the first frame update
    void Start()
    {
        vis = this.GetComponent<SpriteRenderer>(); //assigns spriterenderer of attached object
        vis.enabled = false; //sets red objects to be disabled by default
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnEnable()
    {
        VisToggleEvent.Toggled += VisChange; //on event play, run visibility funtion
    }
    private void OnDisable()
    {
        VisToggleEvent.Toggled -= VisChange; //stops boradcast and disables event on event end
    }

    void VisChange()
    {
        vis.enabled = !vis.enabled; //enables or disables spriterenderer depending on current status (on will become off and off will become on)
    }
} //NOTE: Must be attached to each object rhather than the groups
