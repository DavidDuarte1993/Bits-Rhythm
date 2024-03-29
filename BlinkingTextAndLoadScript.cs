﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement; 

public class BlinkingTextAndLoadScript : MonoBehaviour
{
    Text BlinkingText;
    public string IsBlinkingText = "";
    string WhiteText = "";
    bool IsBlinking = true;
    public float timer;

    public string SceneToLoad;

    void Start()
    {
        IsBlinking = true;

        BlinkingText = GetComponent<Text>();

        StartCoroutine(BlinkText());
    }

    public IEnumerator BlinkText()
    {
        while (IsBlinking)
        {
            BlinkingText.text = WhiteText;
            yield return new WaitForSeconds(.5f);

            BlinkingText.text = IsBlinkingText;
            yield return new WaitForSeconds(1f);
        }
    }
    public void LoadScene()
    {
        StartCoroutine(loadsceneCo());
          
    }
    public void Quit()
    {
        Application.Quit();
    }

    IEnumerator loadsceneCo()
    {
        yield return new WaitForSeconds(timer);
        SceneManager.LoadScene(SceneToLoad);
    }

}
