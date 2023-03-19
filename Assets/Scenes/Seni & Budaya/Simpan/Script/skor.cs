using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class skor : MonoBehaviour
{
    public Text infoSkor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        infoSkor.text = simpan.Skor.ToString();
    }
}
