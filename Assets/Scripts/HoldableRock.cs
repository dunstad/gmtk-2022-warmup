using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldableRock : MonoBehaviour, Holdable
{

    Rigidbody2D body;
    Vector3 startingScale;

    private void Start() {
        body = (Rigidbody2D) gameObject.GetComponent(typeof(Rigidbody2D));
        startingScale = gameObject.transform.localScale;
    }

    void Holdable.OnGrab(Transform grabPoint)
    {
        body.simulated = false;
        gameObject.transform.position = grabPoint.position;
        gameObject.transform.localScale = Vector3.Scale(startingScale, new Vector3(.5f, .5f, .5f));
        gameObject.transform.SetParent(grabPoint);
    }

    void Holdable.OnDrop(Transform grabPoint)
    {
        body.simulated = true;
        gameObject.transform.SetParent(null);
        gameObject.transform.localScale = startingScale;
    }

}