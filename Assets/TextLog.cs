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

    [HideInInspector]
    public float convType;
    public GameObject choices;
    public GameObject reactionBox;
    public Text reactionText;
    [HideInInspector]
    public string reactionDyl;

    public Text opt1Text;
    public Text opt2Text;
    public Text opt3Text;
    public Text opt4Text;
    
    [HideInInspector]
    public int line = 0;
    [HideInInspector]
    public int choiceMade;

    [HideInInspector]
    public int dadConv1Choice1, dadConv1Choice2, dadConv1Choice3, dadConv1Choice4;
    
    [HideInInspector]
    public int momConv1Choice1, momConv1Choice2, momConv1Choice3, momConv1Choice4;

    [HideInInspector]
    public bool dadConvDone, momConvDone;

    [HideInInspector]
    public string convName;
    [HideInInspector]
    public string[] convText;

    
    [HideInInspector]
    public Queue<string> sentences;
    [HideInInspector]
    public string[] choicesOptions;
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();

        convText = new string[3];

           

        choicesOptions = new string[4];

        
        

        PPScript = GameObject.Find("Main Camera").GetComponent<PostProcessingScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(convText[1]);
        //Debug.Log(line);
        //Debug.Log(convName);
        
        
    }
    void FixedUpdate()
    {
        if (line == 1)
        {
            PPScript.SaturationChange(0);
        }
        Debug.Log(line);
        Debug.Log(dadConv1Choice1);
    }
    
    public void setText ()
    {
        if (convName == "DadConv1")
        {
            if (line == 1)
            {                
                    convText[0] = "Sounds mysterious";
                    convText[1] = "Well you're always free to ask";
                    convText[2] = "So what is it bud?";
                    convType = 3;

                reactionDyl = "It's nothing but Ellie asked me if I wanna go to this photography thing tomorrow and I was wondering if you could drive me there";

            }
            else if (line == 2)
            {
                convText[0] = "I mean ofcourse I can drive you there";
                convText[1] = "But Dylan";
                convText[2] = "Does this mean you are going on a date?";
                convType = 2;

                choicesOptions[0] = "It's not like that!";
                choicesOptions[1] = "I think so...";
                choicesOptions[2] = "...";
                choicesOptions[3] = "We're just friends";

                dadConv1Choice2 = choiceMade;
            }
            else if (line == 3)
            {
                dadConv1Choice1 = choiceMade;

                if (dadConv1Choice1 == 1)
                {
                    convText[0] = "Hahahaha";
                    convText[1] = "No need to be emberassed!";
                    convText[2] = "It's fine I'll take you";
                    convType = 3;

                    
                }
                else if (dadConv1Choice1 == 2)
                {
                    convText[0] = "You think so huh?";
                    convText[1] = "Look at you becoming a man";
                    convText[2] = "I'll take you, no problem!";
                    convType = 3;
                }
                else if (dadConv1Choice1 == 3)
                {
                    convText[0] = "Bit shy about it?";
                    convText[1] = "Dont be ashamed it will be fun!";
                    convText[2] = "And don't worry I'll take you there";
                    convType = 3;
                }
                else if (dadConv1Choice1 == 4)
                {
                    convText[0] = "Hmmm just friends huh";
                    convText[1] = "That's what me and your mom used to say as well";
                    convText[2] = "I'll take you to your adventure with your friend";
                    convType = 3;
                }
                reactionDyl = "Thanks dad...";
                
            }
            else if (line == 4)
            {
                convText[0] = "Before you head off to do your homework";
                convText[1] = "I do need to tell you something...";
                convText[2] = "...";
                convType = 3;
                reactionDyl = "Sure! What is it?";
            }
            else if (line == 5)
            {
                convText[0] = "Your mom wasn't feeling to well this morning so we went to the hospital";
                convText[1] = "The doctor noticed a suspicious bump on her body";
                convText[2] = "It turned out she has a tumor";
                convType = 2;

                choicesOptions[0] = "How bad is it?";
                choicesOptions[1] = "How is mom doing? Where is she?";
                choicesOptions[2] = "What....";
                choicesOptions[3] = "Is it treatable?";
            }
            else if (line == 6)
            {
                dadConv1Choice2 = choiceMade;

                if (dadConv1Choice2 == 1)
                {
                    convText[0] = "It needs attention but it's not the worst";
                    convText[1] = "She'll not feel as good or be as active for a while";
                    convText[2] = "But in the end she will be fine";
                    convType = 3;
                    reactionDyl = "...";

                }
                else if (dadConv1Choice2 == 2)
                {
                    convText[0] = "She's okay right now, just a bit shocked";
                    convText[1] = "She's resting in bed currently";
                    convText[2] = "She will probably stay there for the rest of the evening";
                    convType = 3;
                    reactionDyl = "...";
                }
                else if (dadConv1Choice2 == 3)
                {
                    convText[0] = "I know it's a shock";
                    convText[1] = "I wasn't sure what to say at first either";
                    convText[2] = "But everything will be fine don't worry";
                    convType = 3;
                    reactionDyl = "...";
                }
                else if (dadConv1Choice2 == 4)
                {
                    convText[0] = "It is treatable";
                    convText[1] = "The hospital will help her treat it and at some point she will get surgery";
                    convText[2] = "It will take a while though, it won't be cured anytime soon";
                    convType = 3;
                    reactionDyl = "...";
                }
            }
            else if (line == 7)
            {
                convText[0] = "I understand if you're upset about this, this is just something we'll need to get through as a family";
                convText[1] = "If you want to talk to your mother you can, she's currently awake I think";
                convText[2] = "I was making some tea for her, you can grab it and bring it to her if you want";
                convType = 2;

                choicesOptions[0] = "I think I'm going to go to my room to calm down";
                choicesOptions[1] = "Yea.. I'd like to talk to her...";
                choicesOptions[2] = "I'm not sure what to do...";
                choicesOptions[3] = "Maybe I'll go outside to clear my head first";
            }
            else if (line == 8)
            {
                dadConv1Choice3 = choiceMade;

                if (dadConv1Choice3 == 1)
                {
                    convText[0] = "That's fine";
                    convText[1] = "If you need some time for yourself that's understandable";
                    convText[2] = "I'll see you later";
                    
                    

                }
                else if (dadConv1Choice3 == 2)
                {
                    convText[0] = "I think she would like that too";
                    convText[1] = "Maybe you could tell her about  Ellie";
                    convText[2] = "Don't keep her up for too long though, she needs to rest as well";
                    
                    
                }
                else if (dadConv1Choice3 == 3)
                {
                    convText[0] = "That's understandable";
                    convText[1] = "Just take your time to figure things out";
                    convText[2] = "Don't be too upset though, we'll get through this";
                    
                    
                }
                else if (dadConv1Choice3 == 4)
                {
                    convText[0] = "Yea that sounds like a good plan";
                    convText[1] = "The weather is decent so that might help";
                    convText[2] = "Maybe Mr. Rogers is also outside, maybe you can talk to him for a bit";
                    
                    
                }
                convType = 1;
                dadConvDone = true;
            }
        }
        else if (convName == "MomConv1")
        {
            if (line == 1)
            {
                convText[0] = "It will be allright hun";
                convText[1] = "Don't worry too much about it";
                convText[2] = "It's something we will get through just like always, alright?";

                choicesOptions[0] = "I'll believe in you...";
                choicesOptions[1] = "But you're really sick!";
                choicesOptions[2] = "...";
                choicesOptions[3] = "I hope you get better fast...";

                convType = 2;
            }
            if (line == 2)
            {
                momConv1Choice1 = choiceMade;
                if (momConv1Choice1 == 1)
                {
                    convText[0] = "";
                    convText[1] = "";
                    convText[2] = "";
                    
                }
                else if (momConv1Choice1 == 2)
                {
                    convText[0] = "";
                    convText[1] = "";
                    convText[2] = "";

                }
                else if (momConv1Choice1 == 3)
                {
                    convText[0] = "";
                    convText[1] = "";
                    convText[2] = "";

                }
                else if (momConv1Choice1 == 4)
                {
                    convText[0] = "";
                    convText[1] = "";
                    convText[2] = "";

                }
                convType = 2;
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
        reactionBox.SetActive(false);
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
        reactionBox.SetActive(false);
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
        reactionBox.SetActive(false);
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
        reactionBox.SetActive(false);
    }

    public void reaction ()
    {
        line += 1;

        sentences.Clear();

        continueButton1.SetActive(false);
        continueButton2.SetActive(true);

        continueConv();

        choices.SetActive(false);
        reactionBox.SetActive(false);
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
        else if (convType == 3)
        {
            reactionBox.SetActive(true);
            reactionText.text = reactionDyl;
        }
    }
}
