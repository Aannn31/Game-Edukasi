using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pialalevel4 : MonoBehaviour
{
    public void Passpiala4()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if (currentLevel >= PlayerPrefs.GetInt("PialaPassed5"))
        {
            PlayerPrefs.SetInt("PialaPassed5", currentLevel);
        }

        Debug.Log("LEVEL" + PlayerPrefs.GetInt("PialaPassed") + "UNLOCK");
    }
}
