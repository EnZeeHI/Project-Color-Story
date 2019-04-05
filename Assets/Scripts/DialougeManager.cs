using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    public GameObject yesEndGame;
    public GameObject noEndGame;
    public GameObject fadeOut;
    public GameObject continueButton;
    public GameObject reactionBox;
    public Text reactionText;


    // added code for color change
    public bool personIsHappy;

    private void Update()
    {
        //Debug.Log(sentences.Count);
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

        reactionText.text = dialouge.reaction;

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
        else if (convType == 3)
        {
            reactionBox.SetActive(true);
        }
        else if (convType == 4)
        {
            yesEndGame.SetActive(true);
            noEndGame.SetActive(true);
        }
        
        
    }

    public void dontEndGame()
    {
        yesEndGame.SetActive(false);
        noEndGame.SetActive(false);
        UI.SetActive(false);
    }

    public void endGame()
    {
        fadeOut.SetActive(true);
        yesEndGame.SetActive(false);
        noEndGame.SetActive(false);
        continueButton.SetActive(false);
        dialougeText.text = "End of day 13, End of Demo.";
        //SceneManager.LoadScene("Credits Scene");
    }

}
