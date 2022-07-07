using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldableRock : MonoBehaviour, Holdable
{

    Rigidbody2D body;

    private void Start() {
        body = (Rigidbody2D) gameObject.GetComponent(typeof(Rigidbody2D));
    }

    void Holdable.OnGrab(Transform grabPoint)
    {
        body.simulated = false;
        gameObject.transform.SetParent(grabPoint);
        gameObject.transform.position = grabPoint.position;
        gameObject.transform.localScale = new Vector3(.5f, .5f, 1f);
    }

    void Holdable.OnDrop(Transform grabPoint)
    {
        body.simulated = true;
        gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
        gameObject.transform.SetParent(null);
    }

}