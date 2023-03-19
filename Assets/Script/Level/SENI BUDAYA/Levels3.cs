using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Levels3: MonoBehaviour
{
    public Button level02Button, level03Button;
    int levelSeniPZ;

    // Use this for initialization
    void Start()
    {
        levelSeniPZ = PlayerPrefs.GetInt("levelSeniPZ");
        level02Button.interactable = false;
        level03Button.interactable = false;

        switch (levelSeniPZ)
        {
            case 25:
                level02Button.interactable = true;
                break;
            case 26:
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