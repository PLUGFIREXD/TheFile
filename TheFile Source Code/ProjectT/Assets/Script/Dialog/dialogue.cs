using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dialogue : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textComponent;

    [TextArea(3,10)]
    [SerializeField] private string[] lines;

    public float textSpeed;
    [SerializeField] private GameObject dialogueStart;
    private int index;

    bool IsDialogue;

    // Start is called before the first frame update
    void Start()
    {
        dialogueStart.SetActive(false);
        textComponent.text = string.Empty;
        IsDialogue = false;  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && dialogueStart.active == true)
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    private void StartDialogue()
    {
        if(IsDialogue == false)
        {
            dialogueStart.SetActive(true);
            index = 0;
            StartCoroutine(TypeLine());
            IsDialogue = true;
        }
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            index++;
            textComponent.text = string.Empty;
            dialogueStart.SetActive(false);
            IsDialogue = false;
        }
    }
}
