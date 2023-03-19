using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float Scoree;
    public float Highscore;

    public Text scoretext;
    public Text highscoretext;

    public void addscore()
    {
        Scoree +=10;
    }
    // Start is called before the first frame update
    void Start()
    {
        Highscore = PlayerPrefs.GetFloat("Highscore");
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = Scoree.ToString();
        highscoretext.text = Highscore.ToString();

        if ( Scoree > Highscore)
        {
            PlayerPrefs.SetFloat("Highscore", Scoree);
        }
    }
}
