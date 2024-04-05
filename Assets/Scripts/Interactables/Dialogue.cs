using UnityEngine;

public class Dialogue : Interactable
{
    [SerializeField] DialogueContainer dialogue;

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
