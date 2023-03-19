using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Backsound : MonoBehaviour
{
        private static Backsound backsound;

    void Awake()
    {
        if(backsound == null)
        {
            backsound = this;
            DontDestroyOnLoad(backsound);
        }
        else
        {
            Destroy(gameObject);
        }
    }
       
}
