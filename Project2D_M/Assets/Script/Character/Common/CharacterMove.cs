using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class CharacterMove : ScriptEnable
{
    private Rigidbody2D m_characterRigidbody = null;
    private bool m_bFlipX = false;

    private void Start()
    {
        m_characterRigidbody = this.GetComponent<Rigidbody2D>();
    }
    public void MoveLeft(float _speed)
    {
        if (!bScriptEnable)
            return;
        if (!m_bFlipX)
        {
            m_bFlipX = true;
            this.transform.localScale += new Vector3(this.transform.localScale.x * -2, 0, 0);
        }
        m_characterRigidbody.velocity = new Vector2(-_speed, m_characterRigidbody.velocity.y);
    }

    public void MoveRight(float _speed)
    {
        if (!bScriptEnable)
            return;
        if (m_bFlipX)
        {
            m_bFlipX = false;
            this.transform.localScale += new Vector3(this.transform.localScale.x * -2, 0, 0);
        }
        m_characterRigidbody.velocity = new Vector2(_speed, m_characterRigidbody.velocity.y);
    }

    public void MoveStop()
    {
        if (!bScriptEnable)
            return;
        m_characterRigidbody.velocity = new Vector2(0, m_characterRigidbody.velocity.y);
    }
}
