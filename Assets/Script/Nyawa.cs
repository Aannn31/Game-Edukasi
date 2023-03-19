using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nyawa : MonoBehaviour
{
    public GameObject[] nyawa;
    public GameObject kalah;
    private int Life;
    private bool dead;

    private void Start()
    {
        Life = nyawa.Length;
    }

    // Update is called once per frame
    void Update()
    {
        if ( dead == true)
        {
            kalah.SetActive(true);
        }
    }

    public void TakeDamage(int d)
    {
        if (Life >=1)
        {
            Life -= d;
            Destroy(nyawa[Life].gameObject);
            if (Life < 1)
            {
                dead = true;
            }
        }
    }
}
