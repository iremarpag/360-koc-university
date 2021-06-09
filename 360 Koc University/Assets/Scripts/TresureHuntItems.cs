﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TresureHuntItems : MonoBehaviour
{
    public GameObject gameManager;

    public GameObject englishTexts;
    public GameObject turkishTexts;

    public GameObject trophyQuestionMark;
    public GameObject trophyModel;

    public GameObject staplerQuestionMark;
    public GameObject staplerModel;

    // Update is called once per frame
    void Update()
    {
        if (gameManager.GetComponent<GameManager>().isTurkishLangaugeSelected)
        {
            turkishTexts.SetActive(true);
            englishTexts.SetActive(false);
        }

        if (gameManager.GetComponent<GameManager>().isEnglishLanguageSelected)
        {
            turkishTexts.SetActive(false);
            englishTexts.SetActive(true);
        }
    }
}
