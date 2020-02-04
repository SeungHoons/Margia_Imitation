using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class InfoFillAmount : MonoBehaviour
{
    public enum INFO_FILL_TYPE
    {
        EXP,
    }

    public INFO_FILL_TYPE kindOfFillData;
    private float m_fMaxValue;
    private float m_fCurrnetValue;

    [SerializeField] private Image m_imgFillBar = null;
    [SerializeField] private TextMeshProUGUI m_textPersent = null;
    private void Awake()
    {
        Initialized();
    }

    private void Initialized()
    {
        switch(kindOfFillData)
        {
            case INFO_FILL_TYPE.EXP:
                m_fMaxValue = PlayerDataManager.Inst.GetPlayerData().maxExp;
                m_fCurrnetValue = PlayerDataManager.Inst.GetPlayerData().exp;
                break;
        }

        AverageFillBar();
        AverageText();
    }

    void AverageFillBar()
    {
        if(!m_imgFillBar)
        {
            return;
        }

        m_imgFillBar.fillAmount = m_fCurrnetValue / m_fMaxValue;
    }
    
    void AverageText()
    {
        if (!m_textPersent)
        {
            return;
        }

        m_textPersent.text = UpToTheSecondDecimalPlace(m_fCurrnetValue / m_fMaxValue * 100.0f) +"%";
    }

    public string UpToTheSecondDecimalPlace(float data)
    {
        return string.Format("{0:f2}", data); 
    }
}