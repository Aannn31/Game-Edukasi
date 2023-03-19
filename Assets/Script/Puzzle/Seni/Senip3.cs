using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Senip3 : MonoBehaviour
{
    public GameObject senyum;
    public bool selesai = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void cek()
    {
        for (int i= 0; i < 16; i++)
        {
            if (transform.GetChild (i).GetComponent<Seni3> ().on_tempel)
                {
                selesai = true;
            } else
            {
                selesai = false;
                i = 16;
            }
        }
        if (selesai)
        {
            senyum.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!selesai)
        {
            cek();
        }
    }
}
