using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : Interactable
{
    [SerializeField] DialogueContainer dialogue;

    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
        OnInteract += Interact;
    }

    private void OnDestroy()
    {
        OnInteract -= Interact;
    }

    public override void Interact()
    {
        GameManager.Instance.DialogueManager.Initialize(dialogue);
    }
}
