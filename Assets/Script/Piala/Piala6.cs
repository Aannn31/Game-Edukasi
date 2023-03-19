using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Piala6 : MonoBehaviour
{

    // References to trophies game objects to control
    public GameObject cup7;
    int PialaPassed7;

    // Use this for initialization
    void Start()
    {
        PialaPassed7 = PlayerPrefs.GetInt("PialaPassed7");
        cup7.SetActive(false);

        switch (PialaPassed7)
        {
            case 21:
                cup7.SetActive(true);
                break;
        }
    }

    public void Reset()
    {
        cup7.SetActive(false);
        PlayerPrefs.DeleteAll();
    }
}

