using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Closet : Interactable
{
    [SerializeField] private ClothesManager clothesManager;

    public override void Start()
    {
        OnPlayerTriggerEnter += () => clothesManager.SetOnCloset(true);
        OnPlayerTriggerExit += () => clothesManager.SetOnCloset(false);
    }
}
