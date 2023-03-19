using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelss3: MonoBehaviour
{
    public void Passqpz1()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if (currentLevel >= PlayerPrefs.GetInt("levelSeniPZ"))
        {
            PlayerPrefs.SetInt("levelSeniPZ", currentLevel);
        }

        Debug.Log("LEVEL" + PlayerPrefs.GetInt("LevelPassed") + "UNLOCK");
    }
}
