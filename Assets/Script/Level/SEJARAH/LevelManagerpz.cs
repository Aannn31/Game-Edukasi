using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManagerpz : MonoBehaviour
{
    public Button level02Button, level03Button;
    int levelPassedpz;

    // Use this for initialization
    void Start()
    {
        levelPassedpz = PlayerPrefs.GetInt("LevelPassedpz");
        level02Button.interactable = false;
        level03Button.interactable = false;

        switch (levelPassedpz)
        {
            case 7:
                level02Button.interactable = true;
                break;
            case 8:
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