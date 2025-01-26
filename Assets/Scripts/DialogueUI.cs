using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class DialogueUI : MonoBehaviour
{
    private const string V = "Hello!\nFuncinou muito.";
    [SerializeField] private TMP_Text textLabel;

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
    GetComponent<TypingEffect>().Run("Ola, isso foi muito dificil de fazer e eu nao sei se vai da certo socorro tomara que de senão vou me mataaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", textLabel);
  }

