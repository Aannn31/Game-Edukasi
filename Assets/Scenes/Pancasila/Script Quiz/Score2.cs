using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score2 : MonoBehaviour
{
    public float Scoree2;
    public float Highscoree2;

    public Text scoretext;
    public Text highscoretext;

    public void addscore2()
    {
        Scoree2 += 10;
    }
    // Start is called before the first frame update
    void Start()
    {
        Highscoree2 = PlayerPrefs.GetFloat("Highscoree2");
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = Scoree2.ToString();
        highscoretext.text = Highscoree2.ToString();

        if (Scoree2 > Highscoree2)
        {
            PlayerPrefs.SetFloat("Highscoree2", Scoree2);
        }
    }
}
