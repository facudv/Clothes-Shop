using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] public float initialCharacterCurrency;
    private float _characterCurrency;

    private void Awake()
    {
        Instance = this;
        SetCurrency(initialCharacterCurrency);
    }

    public GameObject Player;
    public DialogueManager DialogueManager;
    public UIClothes UIClothes;
    public UICurrency UICurrency;

    public void SetCurrency(float value)
    {
        _characterCurrency = value;
        UICurrency.SetCurrency(_characterCurrency);
    }

    public float GetCurrency() => _characterCurrency;
}
