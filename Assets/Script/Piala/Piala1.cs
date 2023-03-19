using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Piala1 : MonoBehaviour
{

    // References to trophies game objects to control
    public GameObject cup2;
    int PialaPassed2;

    // Use this for initialization
    void Start()
    {
        PialaPassed2 = PlayerPrefs.GetInt("PialaPassed2");
        cup2.SetActive(false);

        switch (PialaPassed2)
        {
            case 6:
                cup2.SetActive(true);
                break;
        }
    }

    public void Reset()
    {
        cup2.SetActive(false);
        PlayerPrefs.DeleteAll();
    }
}

