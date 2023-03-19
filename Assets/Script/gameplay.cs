using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameplay : MonoBehaviour
{

    public string[] soal, jawaban;

    public Text text_soal, text_skor;

    public InputField input_jawaban;

    public GameObject feed_benar, feed_salah, exit, bank_soal;

    int urutan_soal = -1, skor = 0;

    // Use this for initialization
    void Start()
    {
        tampil_soal();
    }

    void tampil_soal()
    {
        urutan_soal++;
        text_soal.text = soal[urutan_soal];
    }

    public void jawab()
    {
        if (urutan_soal < soal.Length - 1)
        {
            if (input_jawaban.text == jawaban[urutan_soal])
            {
                feed_benar.SetActive(false);
                feed_benar.SetActive(true);
                feed_salah.SetActive(false);
                skor += 20;
            }
            else
            {
                feed_benar.SetActive(false);
                feed_salah.SetActive(false);
                feed_salah.SetActive(true);
                skor += -5;
            }
            input_jawaban.text = "";
            tampil_soal();
        }
        else
        {
            if (input_jawaban.text == jawaban[urutan_soal])
            {
                skor += 20;
                skor += -1;
            }
            exit.SetActive(true);
            bank_soal.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        text_skor.text = skor.ToString();
    }
}
