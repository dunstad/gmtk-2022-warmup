using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabPrompt : MonoBehaviour
{
    public GameObject prompt;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = prompt.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // TODO: track which kinds of Holdable we've shown the prompt for
    // only show for each type once
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent(typeof(Holdable)))
        {
            anim.Play("prompt_in");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.GetComponent(typeof(Holdable)))
        {
            anim.Play("prompt_out");
        }
    }

}
