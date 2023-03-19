using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Levels1: MonoBehaviour
{
    public Button level02Button, level03Button;
    int levelSeniquis;

    // Use this for initialization
    void Start()
    {
        levelSeniquis = PlayerPrefs.GetInt("levelSeniquis");
        level02Button.interactable = false;
        level03Button.interactable = false;

        switch (levelSeniquis)
        {
            case 19:
                level02Button.interactable = true;
                break;
            case 20:
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