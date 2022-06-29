using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class DepthLayerManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SortSprites() {
        SpriteRenderer[] sprites = FindObjectsOfType<SpriteRenderer>();
        SpriteRenderer[] sortedSprites = sprites.OrderBy((s) => s.gameObject.transform.position.z).ToArray();
        int defaultLayerValue = SortingLayer.GetLayerValueFromName("Default");
        // SortingLayer.layers.Length;
        foreach (SpriteRenderer sprite in sprites) {
            float z = sprite.gameObject.transform.position.z;
        }
    }
}
