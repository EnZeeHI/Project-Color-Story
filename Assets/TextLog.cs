using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextLog : MonoBehaviour
{
    public Text nameText;
    public Text dialougeText;
    public GameObject UI;
    public GameObject continueButton1;
    public GameObject continueButton2;

    public float convType;
    public GameObject choices;

    public Text opt1Text;
    public Text opt2Text;
    public Text opt3Text;
    public Text opt4Text;

    public int choiceMade;
    public string[] bruv201;
    public string[] bruv202;
    public string[] bruv203;
    public string[] bruv204;
    public int bruv2Type;

    public Queue<string> sentences;
    public string[] choicesOptions;
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();

        bruv201 = new string[3];
        bruv202 = new string[3];
        bruv203 = new string[3];
        bruv204 = new string[3];

        choicesOptions = new string[4];

        bruv201[0] = "Hello";
        bruv201[1] = "is it me";
        bruv201[2] = "bye";

        bruv202[0] = "Hello2";
        bruv202[1] = "is it me2";
        bruv202[2] = "bye2";

        bruv203[0] = "Hello3";
        bruv203[1] = "is it me3";
        bruv203[2] = "bye3";

        bruv204[0] = "Hello3";
        bruv204[1] = "is it me3";
        bruv204[2] = "bye3";

        bruv2Type = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void choice1 ()
    {
        choiceMade = 1;

        sentences.Clear();

        continueButton1.SetActive(false);
        continueButton2.SetActive(true);

        foreach (string sentence in bruv201)
        {
            sentences.Enqueue(sentence);
        }
        
        choicesOptions[0] = "fuck";
        choicesOptions[1] = "duck";
        choicesOptions[2] = "cuck";
        choicesOptions[3] = "suck";

        Debug.Log(sentences);

        continueConv();

        choices.SetActive(false);
    }

    public void choice2()
    {
        choiceMade = 2;

        sentences.Clear();

        continueButton1.SetActive(false);
        continueButton2.SetActive(true);

        foreach (string sentence in bruv202)
        {
            sentences.Enqueue(sentence);
        }

        choicesOptions[0] = "fuck";
        choicesOptions[1] = "duck";
        choicesOptions[2] = "cuck";
        choicesOptions[3] = "suck";

        Debug.Log(sentences);

        continueConv();

        choices.SetActive(false);
    }

    public void choice3()
    {
        choiceMade = 3;

        sentences.Clear();

        continueButton1.SetActive(false);
        continueButton2.SetActive(true);

        foreach (string sentence in bruv203)
        {
            sentences.Enqueue(sentence);
        }

        choicesOptions[0] = "fuck";
        choicesOptions[1] = "duck";
        choicesOptions[2] = "cuck";
        choicesOptions[3] = "suck";

        Debug.Log(sentences);

        continueConv();

        choices.SetActive(false);
    }

    public void choice4()
    {
        choiceMade = 4;

        sentences.Clear();

        continueButton1.SetActive(false);
        continueButton2.SetActive(true);

        foreach (string sentence in bruv204)
        {
            sentences.Enqueue(sentence);
        }

        choicesOptions[0] = "fuck";
        choicesOptions[1] = "duck";
        choicesOptions[2] = "cuck";
        choicesOptions[3] = "suck";

        Debug.Log(sentences);

        continueConv();

        choices.SetActive(false);
    }

    public void continueConv ()
    {


        convType = bruv2Type;
        

        opt1Text.text = choicesOptions[0];
        opt2Text.text = choicesOptions[1];
        opt3Text.text = choicesOptions[2];
        opt4Text.text = choicesOptions[3];

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
        }
    }
}
