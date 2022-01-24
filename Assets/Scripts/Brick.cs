using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Brick : MonoBehaviour
{
    public UnityEvent<int> onDestroyed;
    
    public int PointValue;



    void Start()
    {
        // NEW COLOR
        Color pink = new Color(1f, 0.18f, 0.8f);
        Color bluec = new Color(0.024f, 0.482f, 0.761f);
        Color orange = new Color(1f, 0.533f, 0.067f);


        var renderer = GetComponentInChildren<Renderer>();

        MaterialPropertyBlock block = new MaterialPropertyBlock();
        switch (PointValue)
        {
            case 1 :
                block.SetColor("_BaseColor", pink);
                break;
            case 2:
                block.SetColor("_BaseColor", orange);
                break;
            case 5:
                block.SetColor("_BaseColor", bluec);
                break;
            default:
                block.SetColor("_BaseColor", Color.red);
                break;
        }
        renderer.SetPropertyBlock(block);
    }

    private void OnCollisionEnter(Collision other)
    {
        onDestroyed.Invoke(PointValue);
        
        //slight delay to be sure the ball have time to bounce
        Destroy(gameObject, 0.2f);
    }
}
