using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class InfoText : MonoBehaviour
{
    public enum INFO_TYPE
    {
        LEVEL,
        MAXHP,
        ATTACK,
        DEFENSEIVE,
        CRITICAL,
        EXP,
        MAXEXP,
        GOLD,
        CASH,
        FATIGABILITY,
    }

    public INFO_TYPE infoData;
    public TextMeshProUGUI thisText;

    private void Start()
    {
        Initialized();

		if (infoData == INFO_TYPE.FATIGABILITY)
			InvokeRepeating(nameof(Initialized), 5f, 5f);
    }

	private void Initialized()
    {
        switch(infoData)
        {
            case INFO_TYPE.LEVEL:
                thisText.text = "lv" + PlayerDataManager.Inst.GetPlayerData().level.ToString();
                break;
            case INFO_TYPE.MAXHP:
                thisText.text = GetThousandCommaText(PlayerDataManager.Inst.GetPlayerData().maxHp);
                break;
            case INFO_TYPE.ATTACK:
                thisText.text = GetThousandCommaText(PlayerDataManager.Inst.GetPlayerData().attack);
                break;
            case INFO_TYPE.DEFENSEIVE:
                thisText.text = GetThousandCommaText(PlayerDataManager.Inst.GetPlayerData().defensive);
                break;
            case INFO_TYPE.CRITICAL:
                thisText.text = PlayerDataManager.Inst.GetPlayerData().critical.ToString();
                break;
            case INFO_TYPE.EXP:
                thisText.text = GetThousandCommaText(PlayerDataManager.Inst.GetPlayerData().exp);
                break;
            case INFO_TYPE.MAXEXP:
                thisText.text = GetThousandCommaText(PlayerDataManager.Inst.GetPlayerData().maxExp);
                break;
            case INFO_TYPE.GOLD:
                thisText.text = GetThousandCommaText(PlayerDataManager.Inst.GetPlayerData().gold);
                break;
            case INFO_TYPE.CASH:
                thisText.text = GetThousandCommaText(PlayerDataManager.Inst.GetPlayerData().cash);
                break;
            case INFO_TYPE.FATIGABILITY:
                thisText.text = GetThousandCommaText(PlayerDataManager.Inst.GetPlayerData().fatigability) + "/"
					+ GetThousandCommaText(PlayerDataManager.Inst.GetPlayerData().maxFatigability);
                break;
        }
    }

	public void RefreshStatus()
	{
		switch (infoData)
		{
			case INFO_TYPE.LEVEL:
				thisText.text = "lv" + PlayerDataManager.Inst.GetPlayerData().level.ToString();
				break;
			case INFO_TYPE.MAXHP:
				thisText.text = GetThousandCommaText(PlayerDataManager.Inst.GetPlayerData().maxHp);
				break;
			case INFO_TYPE.ATTACK:
				thisText.text = GetThousandCommaText(PlayerDataManager.Inst.GetPlayerData().attack);
				break;
			case INFO_TYPE.DEFENSEIVE:
				thisText.text = GetThousandCommaText(PlayerDataManager.Inst.GetPlayerData().defensive);
				break;
			case INFO_TYPE.CRITICAL:
				thisText.text = PlayerDataManager.Inst.GetPlayerData().critical.ToString();
				break;
			case INFO_TYPE.EXP:
				thisText.text = GetThousandCommaText(PlayerDataManager.Inst.GetPlayerData().exp);
				break;
			case INFO_TYPE.MAXEXP:
				thisText.text = GetThousandCommaText(PlayerDataManager.Inst.GetPlayerData().maxExp);
				break;
			case INFO_TYPE.GOLD:
				thisText.text = GetThousandCommaText(PlayerDataManager.Inst.GetPlayerData().gold);
				break;
			case INFO_TYPE.CASH:
				thisText.text = GetThousandCommaText(PlayerDataManager.Inst.GetPlayerData().cash);
				break;
			case INFO_TYPE.FATIGABILITY:
				thisText.text = GetThousandCommaText(PlayerDataManager.Inst.GetPlayerData().fatigability) + "/"
					+ GetThousandCommaText(PlayerDataManager.Inst.GetPlayerData().maxFatigability);
				break;
		}
	}

	public string GetThousandCommaText(int data)
    {
		if (data == 0)
			return data.ToString();
		return string.Format("{0:#,###}", data);
    }

}
