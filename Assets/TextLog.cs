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
    public PostProcessingScript PPScript;

    public float convType;
    public GameObject choices;

    public Text opt1Text;
    public Text opt2Text;
    public Text opt3Text;
    public Text opt4Text;

    public int line = 0;
    public int choiceMade;

    public int dadConv1Choice1;
    public int dadConv1Choice2;
    public int dadConv1Choice3;
    public int dadConv1Choice4;


    public string convName;

    public string[] convText;

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

        convText = new string[3];

        bruv201 = new string[3];
        bruv202 = new string[3];
        bruv203 = new string[3];
        bruv204 = new string[3];

        choicesOptions = new string[4];

        
        bruv201[0] = "First day of school huh";
        bruv201[1] = "And it's also your final year";
        bruv201[2] = "Are you excited?";

        bruv202[0] = "First day of school huh";
        bruv202[1] = "And it's also your final year";
        bruv202[2] = "Are you excited?";

        bruv203[0] = "First day of school huh";
        bruv203[1] = "And it's also your final year";
        bruv203[2] = "Are you excited?";

        bruv204[0] = "First day of school huh";
        bruv204[1] = "And it's also your final year";
        bruv204[2] = "Are you excited?";

        bruv2Type = 2;

        PPScript = GameObject.Find("Main Camera").GetComponent<PostProcessingScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(convText[1]);
        //Debug.Log(line);
        Debug.Log(convName);
        
        
    }
    void FixedUpdate()
    {
        if (line == 1)
        {
            PPScript.SaturationChange(0);
        }
    }
    
    public void setText ()
    {
        if (convName == "DadConv1")
        {
            if (line == 1)
            {
                dadConv1Choice1 = choiceMade;

                if (dadConv1Choice1 == 1)
                {
                    convText[0] = "Ham and Cheese it is!";
                    convText[1] = "First day of school huh";
                    convText[2] = "Are you excited?";
                    convType = 2;

                    choicesOptions[0] = "A little bit";
                    choicesOptions[1] = "Not really";
                    choicesOptions[2] = "...";
                    choicesOptions[3] = "How could I ever be excited about school";
                }

                if (dadConv1Choice1 == 2)
                {
                    convText[0] = "Raspberry jam is for nerds but okay";
                    convText[1] = "First day of school huh";
                    convText[2] = "Are you excited?";
                    convType = 2;

                    choicesOptions[0] = "A little bit";
                    choicesOptions[1] = "Not really";
                    choicesOptions[2] = "...";
                    choicesOptions[3] = "How could I ever be excited about school";
                }

                if (dadConv1Choice1 == 3)
                {
                    convText[0] = "Fucking reply you twat";
                    convText[1] = "First day of school huh";
                    convText[2] = "Are you excited?";
                    convType = 2;

                    choicesOptions[0] = "A little bit";
                    choicesOptions[1] = "Not really";
                    choicesOptions[2] = "...";
                    choicesOptions[3] = "How could I ever be excited about school";
                }

                if (dadConv1Choice1 == 4)
                {
                    convText[0] = "kay peanut butter it is";
                    convText[1] = "First day of school huh";
                    convText[2] = "Are you excited?";
                    convType = 2;

                    choicesOptions[0] = "A little bit";
                    choicesOptions[1] = "Not really";
                    choicesOptions[2] = "...";
                    choicesOptions[3] = "How could I ever be excited about school";
                }




            }
            else if (line == 2)
            {
                convText[0] = "Your mom is still in bed";
                convText[1] = "She's feeling a bit iffy today";
                convText[2] = "Could you bring her some food?";
                convType = 2;

                choicesOptions[0] = "I guess I could";
                choicesOptions[1] = "I really need to get to school";
                choicesOptions[2] = "...";
                choicesOptions[3] = "I'll see if I have time";

                dadConv1Choice2 = choiceMade;
            }
            else if (line == 3)
            {
                convText[0] = "I think your mom would be happy to talk to you before you leave";
                convText[1] = "She's really excited for you, you know";
                convText[2] = "Have fun in school today";
                convType = 1;

                dadConv1Choice3 = choiceMade;
            }
        }
    }

    public void whatConv(string convNameHere)
    {
        convName = convNameHere; 
    }
    public void choice1 ()
    {
        choiceMade = 1;
        line += 1;

        sentences.Clear();

        continueButton1.SetActive(false);
        continueButton2.SetActive(true);

        

        

        continueConv();

        choices.SetActive(false);
    }

    public void choice2()
    {
        choiceMade = 2;
        line += 1;
        
        sentences.Clear();

        continueButton1.SetActive(false);
        continueButton2.SetActive(true);

        

        continueConv();

        choices.SetActive(false);
    }

    public void choice3()
    {
        choiceMade = 3;
        line += 1;

        sentences.Clear();

        continueButton1.SetActive(false);
        continueButton2.SetActive(true);

        

        continueConv();

        choices.SetActive(false);
    }

    public void choice4()
    {
        choiceMade = 4;
        line += 1;

        sentences.Clear();

        continueButton1.SetActive(false);
        continueButton2.SetActive(true);

        

        Debug.Log(sentences);

        continueConv();

        choices.SetActive(false);
    }

    public void continueConv ()
    {
        setText();

        foreach (string sentence in convText)
        {
            sentences.Enqueue(sentence);
        }




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
            continueButton1.SetActive(true);
            continueButton2.SetActive(false);
            UI.SetActive(false);
            Debug.Log("End of conversation");
            line = 0;

            Debug.Log(dadConv1Choice1);
            Debug.Log(dadConv1Choice2);
            Debug.Log(dadConv1Choice3);
        }
        else if (convType == 2)
        {
            choices.SetActive(true);
        }
    }
}
