using TMPro;
using UnityEngine;

public class DialogueController : MonoBehaviour
{

    public static DialogueController Instance { get; private set; }

    public GameObject dialogueBox;
    public TMP_Text dialogueText;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void ShowDialogueUI(bool show)
    {
        dialogueBox.SetActive(show);
    }

    public void SetNpcInfo (string npcName)
    {
        dialogueText.text = npcName;
    }
    
    public void SetDialogueText (string text)
    {
        dialogueText.text = text;
    }
}