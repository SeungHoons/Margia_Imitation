using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "PlayerDataScript", menuName = "PlayerData", order = 1)]
[System.Serializable]
public class PlayerDataScriptableObject : ScriptableObject
{
	public string charactorName;
	public int level;
	public int exp;
	public int gold;
	public int cash;
	public int fatigability;

	public string weapon;
	public string hat;
	public string top;
	public string gloves;
	public string pants;
	public string shoes;
	public string necklace;
	public string earring_one;
	public string earring_two;
	public string ring_one;
	public string ring_two;
}

