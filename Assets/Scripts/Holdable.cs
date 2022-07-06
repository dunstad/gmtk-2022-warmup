using UnityEngine;

interface Holdable
{
    void OnGrab(Transform grabPoint);
    void OnDrop(Transform grabPoint);
}