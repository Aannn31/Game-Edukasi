using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Buttonkeyboard : MonoBehaviour
{
    public Text tArea;
    public Image iQuest;
    public GameObject panelresult;
    public NextRound Endgame;
    public GameObject bnext;
    public GameObject bfinish;

    [Header("Heart")]
    public GameObject hearth;
    int countHearth;
    public GameObject losegame;

    void Start()
    {
        countHearth = hearth.transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonkeyboardVirtual ( )
    {
        GameObject keyAbjad = EventSystem.current.currentSelectedGameObject;

        tArea.text += keyAbjad.transform.GetChild(0).GetComponent<Text>().text;
    }

    public void delete ()
    {
        if (tArea.text.Length > 0)
        {
            tArea.text = tArea.text.Remove(tArea.text.Length - 1);
        }
    }

    public void checkjawaban ()
    {
        if (tArea.text == iQuest.sprite.name)
        {
            Debug.Log("Benar");

            panelresult.SetActive(true);
            panelresult.transform.GetChild(0).GetComponent<Image>().sprite = iQuest.sprite;
            panelresult.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = iQuest.sprite.name;

            if (Endgame.round == Endgame.totalround - 1)
            {
                bnext.SetActive(false);
                bfinish.SetActive(true);
            }
        }
        else
        {
            Debug.Log("Salah");

            countHearth -=1;
            hearth.transform.GetChild(countHearth).gameObject.SetActive(false);

            tArea.text = "";

            if (countHearth ==0)
            {
                losegame.SetActive(true);
            }
        }
    }
}
