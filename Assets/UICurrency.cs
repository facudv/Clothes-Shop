using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UICurrency : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI currencyText;

    public void SetCurrency(float currency) => currencyText.text = currency.ToString();
}
