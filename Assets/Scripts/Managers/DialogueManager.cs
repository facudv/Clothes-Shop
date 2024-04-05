using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] Image portrait;
    [SerializeField] TextMeshProUGUI targetText;
    [SerializeField] TextMeshProUGUI nameText;

    DialogueContainer currentDialogue;
    int _currentTextLine;

    private void Start()
    {
        Show(false);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PushText();
        }
    }

    private void PushText()
    {
        _currentTextLine += 1;
        if(_currentTextLine >= currentDialogue.line.Count)
        {
            Conclude();
        }
        else
        {
            targetText.text = currentDialogue.line[_currentTextLine];
        }
    }

    public void Initialize(DialogueContainer dialogueContainer)
    {
        Show(true);
        currentDialogue = dialogueContainer;
        _currentTextLine = 0;
        targetText.text = currentDialogue.line[_currentTextLine];
        UpdatePortrait();
    }

    private void UpdatePortrait()
    {
        portrait.sprite = currentDialogue.character.Portrait;
        nameText.text = currentDialogue.character.Name;
    }

    private void Show(bool value)
    {
        gameObject.SetActive(value);
    }

    private void Conclude()
    {
        Show(false);
    }
}
