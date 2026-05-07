using UnityEngine;

[CreateAssetMenu(fileName = "Dialogue1", menuName = "Scriptable Objects/Dialogue1")]
public class Dialogue1 : ScriptableObject
{
    public string[] dialoguelines;
    public bool[] autoProgressLines;
    public bool[] endDialogueLines;
    public float autoProgressDelay = 1.5f;
    public double typingSpeed = 0.05;
    
    public DialogueChoice[] choices;
}
 
[System.Serializable]
public class DialogueChoice
{
    public int dialogueIndex;
    public string[] choices;
    public int[] nextDialogueIndexes;
}