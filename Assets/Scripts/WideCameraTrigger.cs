using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WideCameraTrigger : MonoBehaviour
{
    public Transform player;
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject == player.gameObject) {
            camera.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (other.gameObject == player.gameObject) {
            camera.SetActive(false);
        }
    }
}
