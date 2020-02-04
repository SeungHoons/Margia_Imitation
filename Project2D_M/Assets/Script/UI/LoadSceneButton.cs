using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class LoadSceneButton : MonoBehaviour
{
    public enum SCENE_NAME
    {
        TITLE,
        LOADING,
        LOBBY,
        INVENTORY,
        WORLDMAP,
        STAGE_1,
		STAGE_2,
		STAGE_3,
		STAGE_4
    }

    public SCENE_NAME wantToGoSceneName;

    public virtual void GotoScene()
    {
		LoadingProgress.LoadScene((int)wantToGoSceneName);
	}

    public void OnClickExit()
    {
        Application.Quit();
    }
}
