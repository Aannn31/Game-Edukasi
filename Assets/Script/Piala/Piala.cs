using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Piala : MonoBehaviour
{

    // References to trophies game objects to control
    public GameObject cup1;
    int PialaPassed;

    // Use this for initialization
    void Start()
    {
        PialaPassed = PlayerPrefs.GetInt("PialaPassed");
        cup1.SetActive(false);

        switch (PialaPassed)
        {
            case 3:
                cup1.SetActive(true);
                break;
        }
    }

    public void Reset()
    {
        cup1.SetActive(false);
        PlayerPrefs.DeleteAll();
    }
}

