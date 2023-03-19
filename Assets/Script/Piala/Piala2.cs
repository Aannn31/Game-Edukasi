using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Piala2 : MonoBehaviour
{

    // References to trophies game objects to control
    public GameObject cup3;
    int PialaPassed3;

    // Use this for initialization
    void Start()
    {
        PialaPassed3 = PlayerPrefs.GetInt("PialaPassed3");
        cup3.SetActive(false);

        switch (PialaPassed3)
        {
            case 9:
                cup3.SetActive(true);
                break;
        }
    }

    public void Reset()
    {
        cup3.SetActive(false);
        PlayerPrefs.DeleteAll();
    }
}

