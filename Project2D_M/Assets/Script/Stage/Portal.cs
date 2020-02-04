using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    //해당 스테이지에 몬스터가 전부 죽였을 경우 활성화
    private bool m_bStageClear = false;


    private void OnTriggerEnter2D(Collider2D _collision)
    {
        if(m_bStageClear && _collision.tag == "Player")
        {
            SceneManager.LoadScene("00_LoadingScene");
        }
    }
}
