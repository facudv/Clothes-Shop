using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Clothes : Interactable
{
    [SerializeField] private ClothesType clotheType;
    [SerializeField] private float currencyCost;
    [SerializeField] private DialogueContainer dialogue;
    private bool _bought;
    private bool IsBought => _bought;

    public override void Start()
    {
        base.Start();
        OnInteract += Interact;
    }

    //private void OnDestroy()
    //{
    //    OnInteract -= Interact;
    //}

    public override void Interact()
    {
        if (IsBought)
        {
            IsBoughtUI();
            return;
        }
        switch (clotheType)
        {
            case ClothesType.Base:
                break;
            case ClothesType.LeatherSuit: 
                GameManager.Instance.UIClothes.GetLeatherSuit().SetActive(true);
                break;
            case ClothesType.SantaClaus:
                GameManager.Instance.UIClothes.GetSantaClaus().SetActive(true);
                break;
            case ClothesType.Rainbow:
                GameManager.Instance.UIClothes.GetRainbow().SetActive(true);
                break;
            default:
                break;
        }
        UpdateCurrency();
        _bought = true;
    }

    private void IsBoughtUI() => GameManager.Instance.DialogueManager.Initialize(dialogue);

    private void UpdateCurrency()
    {
        float currentCurrency = GameManager.Instance.GetCurrency();
        float resultCurrency = currentCurrency - currencyCost;
        GameManager.Instance.SetCurrency(resultCurrency);
        _bought = true;
    }
}