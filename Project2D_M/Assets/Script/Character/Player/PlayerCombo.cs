﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCombo : MonoBehaviour
{
    [SerializeField]private int combo = 0;
    private bool m_bComboPlay = false;
    private PlayerInfo m_playerInfo = null;
    [SerializeField] private float m_fComboTime = 1.5f;
    [SerializeField] private float m_fTickTime = 0.0f;
    public ComboUIManager comboUIManager;
    private void Awake()
    {
        m_playerInfo = this.GetComponent<PlayerInfo>();
    }
    public void plusCombo()
    {
        m_fTickTime = 0;
        combo++;
        m_playerInfo.SetMaxCombo(combo);
        comboUIManager.ShowCombo(combo);
        if (!m_bComboPlay)
        {
            StartCoroutine(nameof(ComboSystem));
        }
    }

    IEnumerator ComboSystem()
    {
        m_bComboPlay = true;

        while(m_fTickTime <= m_fComboTime)
        {
            m_fTickTime += Time.deltaTime;
            yield return null ;
        }
        
        combo = 0;
        comboUIManager.ShowCombo(combo);
        m_bComboPlay = false;
    }
}
