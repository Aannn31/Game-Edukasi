using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pialalevel1 : MonoBehaviour
{
    public void Passpiala1()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if (currentLevel >= PlayerPrefs.GetInt("PialaPassed2"))
        {
            PlayerPrefs.SetInt("PialaPassed2", currentLevel);
        }

        Debug.Log("LEVEL" + PlayerPrefs.GetInt("PialaPassed") + "UNLOCK");
    }
}
