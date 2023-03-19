using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Piala3 : MonoBehaviour
{

    // References to trophies game objects to control
    public GameObject cup4;
    int PialaPassed4;

    // Use this for initialization
    void Start()
    {
        PialaPassed4 = PlayerPrefs.GetInt("PialaPassed4");
        cup4.SetActive(false);

        switch (PialaPassed4)
        {
            case 12:
                cup4.SetActive(true);
                break;
        }
    }

    public void Reset()
    {
        cup4.SetActive(false);
        PlayerPrefs.DeleteAll();
    }
}

