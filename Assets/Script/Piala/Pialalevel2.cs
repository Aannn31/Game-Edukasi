using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pialalevel2 : MonoBehaviour
{
    public void Passpiala2()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if (currentLevel >= PlayerPrefs.GetInt("PialaPassed3"))
        {
            PlayerPrefs.SetInt("PialaPassed3", currentLevel);
        }

        Debug.Log("LEVEL" + PlayerPrefs.GetInt("PialaPassed") + "UNLOCK");
    }
}
