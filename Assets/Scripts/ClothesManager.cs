using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;
using UnityEngine.U2D.Animation;
using UnityEngine.UIElements;

public class ClothesManager : MonoBehaviour
{
    private List<SpriteResolver> _resolvers;
    private ClothesType _clothsType;

    private void Awake()
    {
        _resolvers = GetComponentsInChildren<SpriteResolver>(true).ToList();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _clothsType = _clothsType == ClothesType.Base ? ClothesType.Rainbow : ClothesType.LeatherSuit;
            ChangeClothes();
        }        
    }

    private void ChangeClothes()
    {
        foreach (var resolver in _resolvers)
        {
            resolver.SetCategoryAndLabel(resolver.GetCategory(), _clothsType.ToString());
        }
    }

    private enum ClothesType
    {
        Base,
        LeatherSuit,
        SantaClaus,
        Rainbow,
    }
}
