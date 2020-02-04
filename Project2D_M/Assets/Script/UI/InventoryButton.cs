using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InventoryButton : MonoBehaviour
{
    [SerializeField] private Image m_imgSlot = null;

    public void SetIcon(Sprite _image)
    {
        m_imgSlot.sprite = _image;
    }

}
