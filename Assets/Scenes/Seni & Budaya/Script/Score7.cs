using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score7 : MonoBehaviour
{
    public float Scoree7;
    public float Highscoree7;

    public Text scoretext;
    public Text highscoretext;

    public void addscore7()
    {
        Scoree7 += 10;
    }
    // Start is called before the first frame update
    void Start()
    {
        Highscoree7 = PlayerPrefs.GetFloat("Highscoree7");
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = Scoree7.ToString();
        highscoretext.text = Highscoree7.ToString();

        if (Scoree7 > Highscoree7)
        {
            PlayerPrefs.SetFloat("Highscoree7", Scoree7);
        }
    }
}
