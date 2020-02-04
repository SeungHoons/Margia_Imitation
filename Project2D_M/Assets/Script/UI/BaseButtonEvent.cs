using System.Collections;
using UnityEditor;
using System.Collections.Generic;
using UnityEngine;



public class BaseButtonEvent : MonoBehaviour
{
    public GameObject selectObject;
    public int eventNum;
    public void OpenEventButton() 
    { 
        if(!selectObject)
        {
            return;
        }
        selectObject.SetActive(true);
    }

    public void CloseEventButton()
    {
        if (!selectObject)
        {
            return;
        }
        selectObject.SetActive(false);
    }

    public void PlayAnimation()
    {
        Animator animator = selectObject.GetComponent<Animator>();
   
       if(!animator.GetBool("bOpen"))
        {
            animator.SetBool("bOpen", true);
        }
        else
        {
            animator.SetBool("bOpen", false);
        }
    }


}
