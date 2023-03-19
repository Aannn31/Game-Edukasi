using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score5 : MonoBehaviour
{
    public float Scoree5;
    public float Highscoree5;

    public Text scoretext;
    public Text highscoretext;

    public void addscore5()
    {
        Scoree5 += 10;
    }
    // Start is called before the first frame update
    void Start()
    {
        Highscoree5 = PlayerPrefs.GetFloat("Highscoree5");
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = Scoree5.ToString();
        highscoretext.text = Highscoree5.ToString();

        if (Scoree5 > Highscoree5)
        {
            PlayerPrefs.SetFloat("Highscoree5", Scoree5);
        }
    }
}
