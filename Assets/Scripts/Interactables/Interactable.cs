using System;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField] private GameObject posFeedback;
    private GameObject feedBack;

    private bool CanPerformInteract => _interact;
    private bool _interact;

    protected Action OnInteract;
    protected Action OnPlayerTriggerEnter;
    protected Action OnPlayerTriggerExit;

    public virtual void Start()
    {
         if (posFeedback == null) return;
         feedBack = posFeedback.GetComponentInChildren<Transform>().gameObject;
         EnableFeedBack(false);
    }

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        CharacterController2D player = collision.gameObject.GetComponent<CharacterController2D>();
        if (player)
        {
            EnableInteraction(true);
            EnableFeedBack(true);
            OnPlayerTriggerEnter?.Invoke();
        }
    }

    protected void OnTriggerExit2D(Collider2D collision)
    {
        CharacterController2D player = collision.gameObject.GetComponent<CharacterController2D>();
        if (player)
        {
            EnableInteraction(false);
            EnableFeedBack(false);
            OnPlayerTriggerExit?.Invoke();
        }
    }

    public virtual void Update()
    {
        if(CanPerformInteract)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                OnInteract?.Invoke();
            }
        }
    }

    public virtual void Interact()
    {
    }

    private void EnableFeedBack(bool value) => feedBack?.SetActive(value);
    private void EnableInteraction(bool value) => _interact = value;
}
