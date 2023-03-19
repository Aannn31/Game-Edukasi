using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Piala7 : MonoBehaviour
{

    // References to trophies game objects to control
    public GameObject cup8;
    int PialaPassed8;

    // Use this for initialization
    void Start()
    {
        PialaPassed8 = PlayerPrefs.GetInt("PialaPassed8");
        cup8.SetActive(false);

        switch (PialaPassed8)
        {
            case 24:
                cup8.SetActive(true);
                break;
        }
    }

    public void Reset()
    {
        cup8.SetActive(false);
        PlayerPrefs.DeleteAll();
    }
}

