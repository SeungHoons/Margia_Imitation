using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxCamera : MonoBehaviour
{
    public delegate void ParallaxCameraDelegate(float deltaMovement);
    public ParallaxCameraDelegate cameraTranslate;
    private float m_fOldPosition;
    // Start is called before the first frame update
    void Start()
    {
        m_fOldPosition = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x != m_fOldPosition)
        {
            if(cameraTranslate != null)
            {
                float delta = m_fOldPosition - transform.position.x;

                cameraTranslate(delta);
            }
            m_fOldPosition = transform.position.x;
        }
    }
}
