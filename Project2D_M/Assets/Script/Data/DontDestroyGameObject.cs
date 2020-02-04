using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameSaveData;
using GameSaveDataIO;


public class DontDestroyGameObject : MonoBehaviour
{
	private void Awake()
    {
		if (GameObject.FindGameObjectsWithTag("DataManager").Length <= 1)
			DontDestroyOnLoad(gameObject);
		else Destroy(this.gameObject);
    }
}