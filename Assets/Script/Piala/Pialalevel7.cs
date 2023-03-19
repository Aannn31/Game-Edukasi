using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pialalevel7 : MonoBehaviour
{
    public void Passpiala7()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if (currentLevel >= PlayerPrefs.GetInt("PialaPassed8"))
        {
            PlayerPrefs.SetInt("PialaPassed8", currentLevel);
        }

        Debug.Log("LEVEL" + PlayerPrefs.GetInt("PialaPassed") + "UNLOCK");
    }
}
