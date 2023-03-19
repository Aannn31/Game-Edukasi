using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Levelp3: MonoBehaviour
{
    public Button level02Button, level03Button;
    int levelPancasilapz;

    // Use this for initialization
    void Start()
    {
        levelPancasilapz = PlayerPrefs.GetInt("levelPancasilapz");
        level02Button.interactable = false;
        level03Button.interactable = false;

        switch (levelPancasilapz)
        {
            case 16:
                level02Button.interactable = true;
                break;
            case 17:
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