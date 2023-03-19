using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextRound : MonoBehaviour
{
    public int round;
    public int totalround;
    public Sprite[] QuestGame;
    public Image questImage;
    public Generatekey gkrekeyboard;
    public Text tarea;

    [Header("Button Next Round")]
    public GameObject pNextRound;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RandomQuestGame()
    {
        for ( int i = 0; i < QuestGame.Length; i++)
        {
            Sprite a = QuestGame[i];
            int b = Random.Range(0, QuestGame.Length);
            QuestGame[i] = QuestGame[b];
            QuestGame[b] = a;
        }

        questImage.sprite = QuestGame[round];
    }

    public void ButtonNext()
    {
        pNextRound.SetActive(false);

        round += 1;

        questImage.sprite = QuestGame[round];

        gkrekeyboard.ReGeneratekey();

        tarea.text = "";
    }
    public void Tryagain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
