using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score8 : MonoBehaviour
{
    public float Scoree8;
    public float Highscoree8;

    public Text scoretext;
    public Text highscoretext;

    public void addscore8()
    {
        Scoree8 += 10;
    }
    // Start is called before the first frame update
    void Start()
    {
        Highscoree8 = PlayerPrefs.GetFloat("Highscoree8");
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = Scoree8.ToString();
        highscoretext.text = Highscoree8.ToString();

        if (Scoree8 > Highscoree8)
        {
            PlayerPrefs.SetFloat("Highscoree8", Scoree8);
        }
    }
}
