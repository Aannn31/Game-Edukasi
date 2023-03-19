using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Piala4 : MonoBehaviour
{

    // References to trophies game objects to control
    public GameObject cup5;
    int PialaPassed5;

    // Use this for initialization
    void Start()
    {
        PialaPassed5 = PlayerPrefs.GetInt("PialaPassed5");
        cup5.SetActive(false);

        switch (PialaPassed5)
        {
            case 15:
                cup5.SetActive(true);
                break;
        }
    }

    public void Reset()
    {
        cup5.SetActive(false);
        PlayerPrefs.DeleteAll();
    }
}

