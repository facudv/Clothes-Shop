using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Dialogue/Dialogue")]
public class DialogueContainer : ScriptableObject
{
    public List<string> line;
    public Character character;
}
