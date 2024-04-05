using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject Player;
    public DialogueManager DialogueManager;
    public UIClothes UIClothes;
    public UICurrency UICurrency;
    public ClothesManager clothesManager;

    [SerializeField] private float initialCharacterCurrency;
    private float _characterCurrency;

    [SerializeField] private DialogueContainer tutorialDialogue;

    private void Awake()
    {
        Instance = this;
        SetTutorial();
        SetCurrency(initialCharacterCurrency);
        SetUIClothesLogic();
    }

    private void SetUIClothesLogic()
    {
        UIClothes.GetSantaClaus().GetComponentInChildren<Button>().onClick.AddListener(() => clothesManager.SetClothes(ClothesType.SantaClaus));
        UIClothes.GetRainbow().GetComponentInChildren<Button>().onClick.AddListener(() => clothesManager.SetClothes(ClothesType.Rainbow));
        UIClothes.GetLeatherSuit().GetComponentInChildren<Button>().onClick.AddListener(() => clothesManager.SetClothes(ClothesType.LeatherSuit));
    }

    private void SetTutorial()
    {
        DialogueManager.Initialize(tutorialDialogue);
    }

    public void SetCurrency(float value)
    {
        _characterCurrency = value;
        UICurrency.SetCurrency(_characterCurrency);
    }

    public float GetCurrency() => _characterCurrency;
}
