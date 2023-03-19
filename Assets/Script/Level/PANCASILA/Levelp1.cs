using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Levelp1: MonoBehaviour
{
    public Button level02Button, level03Button;
    int levelPancasilaquis;

    // Use this for initialization
    void Start()
    {
        levelPancasilaquis = PlayerPrefs.GetInt("levelPancasilaquis");
        level02Button.interactable = false;
        level03Button.interactable = false;

        switch (levelPancasilaquis)
        {
            case 10:
                level02Button.interactable = true;
                break;
            case 11:
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