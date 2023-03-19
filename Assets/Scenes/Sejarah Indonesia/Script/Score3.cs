using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score3 : MonoBehaviour
{
    public float Scoree3;
    public float Highscoree3;

    public Text scoretext;
    public Text highscoretext;

    public void addscore3()
    {
        Scoree3 += 10;
    }
    // Start is called before the first frame update
    void Start()
    {
        Highscoree3 = PlayerPrefs.GetFloat("Highscoree3");
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = Scoree3.ToString();
        highscoretext.text = Highscoree3.ToString();

        if (Scoree3 > Highscoree3)
        {
            PlayerPrefs.SetFloat("Highscoree3", Scoree3);
        }
    }
}
