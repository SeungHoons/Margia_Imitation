using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackGround : MonoBehaviour
{
    public ParallaxCamera parallaxCamera;
    private List<ParallaxLayer> m_lParallaxLayer = new List<ParallaxLayer>();
    // Start is called before the first frame update
    void Start()
    {
        if (parallaxCamera == null)
            parallaxCamera = Camera.main.GetComponent<ParallaxCamera>();

        if (parallaxCamera != null)
            parallaxCamera.cameraTranslate += Move;
        SetLayer();
        
    }

    void SetLayer()
    {
        m_lParallaxLayer.Clear();
        for(int i = 0; i< transform.childCount; i++)
        {
            ParallaxLayer layer = transform.GetChild(i).GetComponent<ParallaxLayer>();

            if(layer != null)
            {
                layer.name = "Layer-" + i;
                m_lParallaxLayer.Add(layer);
            }
        }
    }

    void Move(float _delta)
    {
        foreach(ParallaxLayer layer in m_lParallaxLayer)
        {
            layer.Move(_delta);
        }
    }
}
