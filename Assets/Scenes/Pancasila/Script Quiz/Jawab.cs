using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jawab : MonoBehaviour
{
    public GameObject feed_benar, feed_salahh;
    // Start is called before the first frame update
    void Start()
    {

    }
    
    public void jawaban (bool jawab)
    {
        if (jawab)
        {
            feed_benar.SetActive(false);
            feed_benar.SetActive(true);
        }


        else
        {
            feed_salahh.SetActive(false);
            feed_salahh.SetActive(true);
        }
        gameObject.SetActive(false);

        transform.parent.GetChild(gameObject.transform.GetSiblingIndex() + 1).gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
