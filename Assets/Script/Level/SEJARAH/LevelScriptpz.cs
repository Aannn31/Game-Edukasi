using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelScriptpz : MonoBehaviour
{
    public void Passpz()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if (currentLevel >= PlayerPrefs.GetInt("LevelPassedpz"))
        {
            PlayerPrefs.SetInt("LevelPassedpz", currentLevel);
        }

        Debug.Log("LEVEL" + PlayerPrefs.GetInt("LevelPassed") + "UNLOCK");
    }
}
