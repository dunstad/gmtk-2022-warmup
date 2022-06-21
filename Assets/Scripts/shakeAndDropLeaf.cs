using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shakeAndDropLeaf : MonoBehaviour
{
    private Animator anim;
    private Renderer rend;
    public GameObject leaf;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        rend = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.name != "leaf" && rend.sortingLayerName == "-1") {
            anim.Play("shake");
            GameObject newLeaf = Instantiate(leaf, other.transform.position, Quaternion.identity);
            newLeaf.name = "leaf";
        }
    }
}
