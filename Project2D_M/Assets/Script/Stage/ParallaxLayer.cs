using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ParallaxLayer : MonoBehaviour
{
    public float parallaxFactor;
    
    public void Move(float _delta)
    {
        Vector3 newPos = transform.localPosition;
        newPos.x -= _delta * parallaxFactor;

        transform.localPosition = newPos;
    }
}
