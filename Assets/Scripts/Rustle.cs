using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rustle : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        // need a way to tell what depth layer we're in
        if (other.gameObject.name != "leaf") {
            anim.Play("rustle");
        }
    }
}
