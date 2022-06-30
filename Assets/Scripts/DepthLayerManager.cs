using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class DepthLayerManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SortSprites();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // set sprite render order based on Z axis position
    public void SortSprites() {
        Debug.Log("sprite order sorted");
        SpriteRenderer[] sprites = FindObjectsOfType<SpriteRenderer>();
        SpriteRenderer[] sortedSprites = sprites.OrderBy((s) => s.gameObject.transform.position.z).ToArray();
        int defaultLayerValue = SortingLayer.GetLayerValueFromName("Default");
        foreach (SpriteRenderer sprite in sprites) {
            float z = sprite.gameObject.transform.position.z;
            sprite.sortingOrder = (int) Math.Round(z, 0);
        }
    }
}
