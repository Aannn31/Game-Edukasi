using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public Image loadingfill;

    void Start()
    {
        StartCoroutine(Load());
    }
    IEnumerator Load()
    {
        AsyncOperation loading = SceneManager.LoadSceneAsync("Tebak Gambar"); 

        while(!loading.isDone)
        {
            loadingfill.fillAmount = loading.progress/0.9f;
            yield return null;
        }
    }
}
