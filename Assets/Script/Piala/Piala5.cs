using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Piala5 : MonoBehaviour
{

    // References to trophies game objects to control
    public GameObject cup6;
    int PialaPassed6;

    // Use this for initialization
    void Start()
    {
        PialaPassed6 = PlayerPrefs.GetInt("PialaPassed6");
        cup6.SetActive(false);

        switch (PialaPassed6)
        {
            case 18:
                cup6.SetActive(true);
                break;
        }
    }

    public void Reset()
    {
        cup6.SetActive(false);
        PlayerPrefs.DeleteAll();
    }
}

