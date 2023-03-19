using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tebakgambar : MonoBehaviour
{
    public GameObject soalnya, soallanjut;
    public string jawaban;
    public Text info, jawab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void cek()
    {
        StartCoroutine(Ngecek());
    }

    IEnumerator Ngecek()
    {
        if (jawab.text == jawaban)
        {
            info.text = " Hebat...!";
            simpan.Skor +=20;
            yield return new WaitForSeconds(1f);
            soalnya.SetActive(false);
            soallanjut.SetActive(true);
            info.text = "";
        }
        else
        {
            info.text = " Yahh Salahh...!";
            simpan.Skor += -5;
            yield return new WaitForSeconds(1f);
            info.text = "";
        }
    }
}
