using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Levelp2: MonoBehaviour
{
    public Button level02Button, level03Button;
    int levelPancasilatg;

    // Use this for initialization
    void Start()
    {
        levelPancasilatg = PlayerPrefs.GetInt("levelPancasilatg");
        level02Button.interactable = false;
        level03Button.interactable = false;

        switch (levelPancasilatg)
        {
            case 13:
                level02Button.interactable = true;
                break;
            case 14:
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