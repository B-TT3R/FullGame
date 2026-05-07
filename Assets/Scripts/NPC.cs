using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPC : MonoBehaviour 
{
    public Dialogue1 dialogueData;
    private DialogueController dialogueUI;
    private int dialogueIndex;
    private bool istyping, isDialogueActive;

    private void Start()
    {
        dialogueUI = DialogueController.Instance;
    }

    public bool CanInteract()
    {
        return !isDialogueActive;
    }

    public void Interact()
    {
        if (dialogueData == null || (!isDialogueActive))
            return;

        if (isDialogueActive)
        {
            Nextline();
        }
        else
        {
            startDialogue();
        }
    }

    void startDialogue()
    {
        isDialogueActive = true;
        dialogueIndex = 0;

        dialogueUI.SetNpcInfo(dialogueData.name);
        dialogueUI.ShowDialogueUI(true);
       

        StartCoroutine(TypeLine());
    }

    void Nextline()
    {
        if (istyping)
        {
            dialogueUI.SetDialogueText(dialogueData.dialoguelines[dialogueIndex]);
            istyping = false;
        }
        else if (++dialogueIndex >= dialogueData.dialoguelines.Length)
        {
            StartCoroutine(TypeLine());
        }
        else
        {
            EndDialogue();
        }
    }

    IEnumerator TypeLine()
    {
        istyping = true;
        dialogueUI.SetDialogueText("");

        foreach (char letter in dialogueData.dialoguelines[dialogueIndex])
        {
            dialogueUI.SetDialogueText(dialogueUI.dialogueText.text += letter);
            yield return new WaitForSeconds((float)dialogueData.typingSpeed);
        }

        istyping = false;

        if (dialogueData.autoProgressLines[dialogueIndex])
        {
            yield return new WaitForSeconds(dialogueData.autoProgressDelay);
            Nextline();
        }
    }

    public void EndDialogue()
    {
        StopAllCoroutines();
        isDialogueActive = false;
        dialogueUI.SetDialogueText("");
       
    }
}
