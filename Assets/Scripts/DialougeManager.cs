using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialougeManager : MonoBehaviour
{
    public Text nameText;
    public Text dialougeText;
    public GameObject UI;

    private Queue<string> sentences;

    public float convType;
    public GameObject choices;

    public Text opt1Text;
    public Text opt2Text;
    public Text opt3Text;
    public Text opt4Text;

    public int choiceMade;

    public string convNameHere;


    // added code for color change
    public bool personIsHappy;

    private void Update()
    {
        Debug.Log(sentences.Count);
    }
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialouge (Dialouge dialouge)
    {

        nameText.text = dialouge.name;

        sentences.Clear();

        foreach (string sentence in dialouge.sentences)
        {
            sentences.Enqueue(sentence);
        }

        opt1Text.text = dialouge.choices[0];
        opt2Text.text = dialouge.choices[1];
        opt3Text.text = dialouge.choices[2];
        opt4Text.text = dialouge.choices[3];

        convNameHere = dialouge.convName;

        FindObjectOfType<TextLog>().whatConv(convNameHere);

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialouge();
            return;
        }

        string sentence = sentences.Dequeue();
        dialougeText.text = sentence;
    }

    void EndDialouge()
    {
        
        if (convType == 1)
        {
            UI.SetActive(false);
            Debug.Log("End of conversation");
        }
        else if (convType == 2)
        {
            choices.SetActive(true);
            sentences.Clear();
            
        }
        personIsHappy = true;
    }
    
   
}
