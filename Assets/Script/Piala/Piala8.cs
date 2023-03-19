using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Piala8 : MonoBehaviour
{

    // References to trophies game objects to control
    public GameObject cup9;
    int PialaPassed9;

    // Use this for initialization
    void Start()
    {
        PialaPassed9 = PlayerPrefs.GetInt("PialaPassed9");
        cup9.SetActive(false);

        switch (PialaPassed9)
        {
            case 27:
                cup9.SetActive(true);
                break;
        }
    }

    public void Reset()
    {
        cup9.SetActive(false);
        PlayerPrefs.DeleteAll();
    }
}

