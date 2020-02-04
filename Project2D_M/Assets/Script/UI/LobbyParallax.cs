using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class LobbyParallax : MonoBehaviour
{
    private float   m_fLength;
    private float   m_fStartPosition;

    public GameObject cameraObject;
    public float    parallaxEffect;

    // Start is called before the first frame update
    void Start()
    {
        m_fStartPosition = transform.position.x;
        m_fLength = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float tempDist = (cameraObject.transform.position.x * parallaxEffect);

        transform.position = new Vector3(m_fStartPosition + tempDist, transform.position.y, transform.position.z);

    }
}
