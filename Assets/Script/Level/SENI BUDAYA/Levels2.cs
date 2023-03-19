using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Levels2: MonoBehaviour
{
    public Button level02Button, level03Button;
    int levelSeniTG;

    // Use this for initialization
    void Start()
    {
        levelSeniTG = PlayerPrefs.GetInt("levelSeniTG");
        level02Button.interactable = false;
        level03Button.interactable = false;

        switch (levelSeniTG)
        {
            case 22:
                level02Button.interactable = true;
                break;
            case 23:
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