using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score6 : MonoBehaviour
{
    public float Scoree6;
    public float Highscoree6;

    public Text scoretext;
    public Text highscoretext;

    public void addscore6()
    {
        Scoree6 += 10;
    }
    // Start is called before the first frame update
    void Start()
    {
        Highscoree6 = PlayerPrefs.GetFloat("Highscoree6");
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = Scoree6.ToString();
        highscoretext.text = Highscoree6.ToString();

        if (Scoree6 > Highscoree6)
        {
            PlayerPrefs.SetFloat("Highscoree6", Scoree6);
        }
    }
}
