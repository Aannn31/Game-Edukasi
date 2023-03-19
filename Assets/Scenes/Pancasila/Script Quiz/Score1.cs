using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score1 : MonoBehaviour
{
    public float Scoree1;
    public float Highscoree1;

    public Text scoretext;
    public Text highscoretext;

    public void addscore1()
    {
        Scoree1 += 10;
    }
    // Start is called before the first frame update
    void Start()
    {
        Highscoree1 = PlayerPrefs.GetFloat("Highscoree1");
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = Scoree1.ToString();
        highscoretext.text = Highscoree1.ToString();

        if (Scoree1 > Highscoree1)
        {
            PlayerPrefs.SetFloat("Highscoree1", Scoree1);
        }
    }
}
