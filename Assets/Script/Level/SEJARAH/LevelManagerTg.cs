using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManagerTg : MonoBehaviour
{
    public Button level02Button, level03Button;
    int levelPassedTg;

    // Use this for initialization
    void Start()
    {
        levelPassedTg = PlayerPrefs.GetInt("LevelPassedTg");
        level02Button.interactable = false;
        level03Button.interactable = false;

        switch (levelPassedTg)
        {
            case 4:
                level02Button.interactable = true;
                break;
            case 5:
                level02Button.interactable = true;
                level03Button.interactable = true;
                break;
        }
    }

    public void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }

    public void resetPlayerPrefs()
    {
        level02Button.interactable = false;
        level03Button.interactable = false;
        PlayerPrefs.DeleteAll();
    }
}