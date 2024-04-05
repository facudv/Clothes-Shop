using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField] private GameObject posFeedback;
    private GameObject feedBack;

    private void Start()
    {
         feedBack = posFeedback.GetComponentInChildren<Transform>().gameObject;
         EnableFeedBack(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CharacterController2D player = collision.gameObject.GetComponent<CharacterController2D>();
        if (player)
            EnableFeedBack(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        CharacterController2D player = collision.gameObject.GetComponent<CharacterController2D>();
        if (player)
            EnableFeedBack(false);  
    }

    private void EnableFeedBack(bool value) => feedBack.SetActive(value);
}
