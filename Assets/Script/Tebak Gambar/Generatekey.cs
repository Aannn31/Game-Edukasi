using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Generatekey : MonoBehaviour
{
    public Buttonkeyboard imageQuest;
    public List<string> addString;
    public string[] randomString;
    public GameObject keyboard;
    public NextRound nrrandomimage;

    public int totalButton;
    // Start is called before the first frame update
    void Start()
    {
        nrrandomimage.RandomQuestGame();

        Namaimage();

        AddRandomString();

        RandomFinishString();

        Showingkeyboard();
    }

    void Update()
    {

    }

    public void ReGeneratekey()
    {
        addString.Clear();

        Namaimage();

        AddRandomString();

        RandomFinishString();

        Showingkeyboard();
    }

    void Showingkeyboard()
    {
        for (int i = 0; i < totalButton; i++)
        {
            keyboard.transform.GetChild(i).GetChild(0).GetComponent<Text>().text = addString[i];
        }
    }

    void RandomFinishString()
    {
        for ( int i = 0; i < addString.Count; i++)
        {
            string a = addString[i];
            int b = Random.Range(0, addString.Count);
            addString[i] = addString[b];
            addString[b] = a;
        }
    }

    void AddRandomString()
    {
        for (int i = 0; i < totalButton; i++)
        {
            if (addString.Count < totalButton)
            {
                int index = Random.Range(0, randomString.Length);

                for (int j = 0; j < addString.Count; j++)
                {
                    if (randomString[index] != addString[j])
                    {
                        if ( j == addString.Count - 1)
                        {
                            addString.Add(randomString[index]);

                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                return;
            }
        }
    }

    void Namaimage()
    {
        for (int i = 0; i < imageQuest.iQuest.sprite.name.Length; i++)
        {
            if (addString.Count == 0)
            {
                addString.Add(imageQuest.iQuest.sprite.name[i].ToString());
            }
            else
            {
                for (int j = 0; j < addString.Count; j++)
                {
                    if (imageQuest.iQuest.sprite.name[i].ToString() != addString[j])
                    {
                        if (j == addString.Count - 1)
                        {
                            addString.Add(imageQuest.iQuest.sprite.name[i].ToString());

                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

    }
}
