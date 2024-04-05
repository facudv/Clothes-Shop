using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIClothes : MonoBehaviour
{
    [SerializeField] private GameObject SantaClaus;
    [SerializeField] private GameObject LeatherSuit;
    [SerializeField] private GameObject Rainbow;

    public GameObject GetSantaClaus() => SantaClaus;
    public GameObject GetLeatherSuit() => LeatherSuit;
    public GameObject GetRainbow() => Rainbow;
}
