using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelss1: MonoBehaviour
{
    public void Passqzs1()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if (currentLevel >= PlayerPrefs.GetInt("levelSeniquis"))
        {
            PlayerPrefs.SetInt("levelSeniquis", currentLevel);
        }

        Debug.Log("LEVEL" + PlayerPrefs.GetInt("LevelPassed") + "UNLOCK");
    }
}
