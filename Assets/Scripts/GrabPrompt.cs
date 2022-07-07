using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabPrompt : MonoBehaviour
{
    public GameObject prompt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent(typeof(Holdable)))
        {
            prompt.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.GetComponent(typeof(Holdable)))
        {
            prompt.SetActive(false);
        }
    }

}
