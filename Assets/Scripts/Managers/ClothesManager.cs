using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class ClothesManager : MonoBehaviour
{
    private List<SpriteResolver> _resolvers;
    private ClothesType _clothsType;
    [SerializeField] private DialogueContainer dialogue;
    private bool OnCloset() => _onCloset;
    private bool _onCloset;

    private void Awake()
    {
        _resolvers = GetComponentsInChildren<SpriteResolver>(true).ToList();
    }


    private void ChangeClothes()
    {
        foreach (var resolver in _resolvers)
        {
            resolver.SetCategoryAndLabel(resolver.GetCategory(), _clothsType.ToString());
        }
    }
    public void SetClothes(ClothesType type)
    {
        if(!OnCloset())
        {
            GameManager.Instance.DialogueManager.Initialize(dialogue);
            return;
        }
        _clothsType = type;
        ChangeClothes();
    }

    public void SetOnCloset(bool value) => _onCloset = value;
}

public enum ClothesType
{
    Base,
    LeatherSuit,
    SantaClaus,
    Rainbow,
}
