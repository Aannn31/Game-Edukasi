using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pialalevel : MonoBehaviour
{
    public void Passpiala()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if (currentLevel >= PlayerPrefs.GetInt("PialaPassed"))
        {
            PlayerPrefs.SetInt("PialaPassed", currentLevel);
        }

        Debug.Log("LEVEL" + PlayerPrefs.GetInt("PialaPassed") + "UNLOCK");
    }
}
