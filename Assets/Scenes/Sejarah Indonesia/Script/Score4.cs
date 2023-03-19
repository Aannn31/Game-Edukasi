using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score4 : MonoBehaviour
{
    public float Scoree4;
    public float Highscoree4;

    public Text scoretext;
    public Text highscoretext;

    public void addscore4()
    {
        Scoree4 += 10;
    }
    // Start is called before the first frame update
    void Start()
    {
        Highscoree4 = PlayerPrefs.GetFloat("Highscoree4");
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = Scoree4.ToString();
        highscoretext.text = Highscoree4.ToString();

        if (Scoree4 > Highscoree4)
        {
            PlayerPrefs.SetFloat("Highscoree4", Scoree4);
        }
    }
}
