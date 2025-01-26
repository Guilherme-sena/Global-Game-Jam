using UnityEngine;
using TMPro;
using System.Collections;
using Unity.VisualScripting;

public class DialogueUI : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;
  private TypingEffect typingEffect;

  private void Start()
  {
  typingEffect = GetComponent<TypingEffect>();
  }

  public void ShowDialogue(DialogueObject dialogueObject)
  {

  }

  // private IEnumerator StepThroughDialogue(DialogueObject dialogueObject)
  // {
  //   foreach(string dialogue in dialogueObject.Dialogue)
  //   {
  //     yield return typingEffect.runInEditMode(dialogue, textLabel);
  //   }
  // }
}
