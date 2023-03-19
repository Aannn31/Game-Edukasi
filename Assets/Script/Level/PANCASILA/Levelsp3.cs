using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelsp3: MonoBehaviour
{
    public void Passpz1()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if (currentLevel >= PlayerPrefs.GetInt("levelPancasilapz"))
        {
            PlayerPrefs.SetInt("levelPancasilapz", currentLevel);
        }

        Debug.Log("LEVEL" + PlayerPrefs.GetInt("LevelPassed") + "UNLOCK");
    }
}
