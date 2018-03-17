using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneOnClick : MonoBehaviour {

	public void LoadGameScene()
    {
        int enemies = InputFieldControl.getEnemiesNumber();
        if(enemies > 0)
        {
            SceneManager.LoadScene("MainScene");
        }
    }

    public void LoadMainMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

    

