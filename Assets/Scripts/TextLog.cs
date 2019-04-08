﻿using System.Collections;
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

    public GameObject neighbour;

    public GameObject dad;
    public GameObject mom;
    public GameObject neighbouryeet;


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
    public int neighbourConv1Choice1, neighbourConv1Choice2, neighbourConv1Choice3, neighbourConv1Choice4;

    [HideInInspector]
    public bool dadConvDone, momConvDone, neighbourConvDone;

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
        if (line >= 6 && convName == "DadConv1")
        {
            PPScript.SaturationChange(-100);
        }
        else if (momConvDone == true && neighbourConvDone == false|| neighbourConvDone == true && momConvDone == false)
        {
             PPScript.SaturationChange(-70);
           
        }
        else if (neighbourConvDone == true && momConvDone == true)
        {
            PPScript.SaturationChange(-30);
            
        }
        //Debug.Log(line);
        //Debug.Log(dadConv1Choice1);
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
                    convText[1] = "No need to be embarrassed!";
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
                    convText[1] = "Don't be ashamed it will be fun!";
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
                choicesOptions[1] = "Yeah... I'd like to talk to her...";
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
                    convText[0] = "Yeah that sounds like a good plan";
                    convText[1] = "The weather is decent so that might help";
                    convText[2] = "Maybe Mr. Rogers is also outside, maybe you can talk to him for a bit";
                    
                    
                }
                convType = 1;
                dadConvDone = true;
                neighbour.SetActive(true);
                dad.tag = "Untagged";
            }
        }
        else if (convName == "MomConv1")
        {
            if (line == 1)
            {
                convText[0] = "It will be alright hun";
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
                    convText[0] = "Your mom is a strong Lady";
                    convText[1] = "Some sickness can't keep her down!";
                    convText[2] = "How was your day at school by the way?";
                    
                }
                else if (momConv1Choice1 == 2)
                {
                    convText[0] = "It's not that bad, don't worry";
                    convText[1] = "Didn't your dad tell you it was cureable?";
                    convText[2] = "Anyway, let's talk about something more fun, how was school honey?";

                }
                else if (momConv1Choice1 == 3)
                {
                    convText[0] = "Don't worry too much hun, it will be fine";
                    convText[1] = "In a few months I'll be all cured and back on my feet!";
                    convText[2] = "Tell me, how was school today?";

                }
                else if (momConv1Choice1 == 4)
                {
                    convText[0] = "So do I hun, hopefully everything goes as fast as the doctor said it would";
                    convText[1] = "Then we should be completely fine in about half a year's time";
                    convText[2] = "Speaking about time, how was your time at school today?";

                }

                choicesOptions[0] = "Ellie asked me to come to a photograph thingy tomorrow!";
                choicesOptions[1] = "Nothing too special...";
                choicesOptions[2] = "School was okay, the same as usual";
                choicesOptions[3] = "I think I might be going on a date?";

                convType = 2;
            }
            else if (line == 3)
            {
                momConv1Choice2 = choiceMade;
                if (momConv1Choice2 == 1)
                {
                    convText[0] = "Ellie is the girl you talked about before right? How fun!";
                    convText[1] = "Are you into photography now?";
                    convText[2] = "If so, I think we still have an old camera laying around from your grand father, I could go find it for you tomorrow.";

                    reactionDyl = "That would be amazing mom!";
                }
                else if (momConv1Choice2 == 2)
                {
                    convText[0] = "Nothing too special again? What do you call not too special?";
                    convText[1] = "We have an old camera laying around the house somewhere";
                    convText[2] = "Maybe you can take pictures of your nothing too special days, so you can show your mom what you mean with not too special";

                    reactionDyl = "I mean... I could try, especially now that you probably won't leave the house much";
                }
                else if (momConv1Choice2 == 3)
                {
                    convText[0] = "Yea I guess school isn't too interesting sometimes";
                    convText[1] = "Don't you have any fun classes?";
                    convText[2] = "Or friends that make your classes more enjoyable?";

                    reactionDyl = "I mean.. I do.... but it's still school...";

                }
                else if (momConv1Choice2 == 4)
                {
                    convText[0] = "On a date?! With that girl Ellie you told me about before?";
                    convText[1] = "That's amazing! I'm so happy for you!";
                    convText[2] = "We have a camera lying around somewhere, I can try and find it for you tomorrow so you can take pictures of your first date!";

                    reactionDyl = "Thank you so much mom, I'm still quite nervous about the whole thing, but I would love to take that camera with me";
                }
               
                convType = 3;
            }
            else if (line == 4)
            {
                convText[0] = "Hearing about how you are doing and how your day went always makes me happy";
                convText[1] = "Even now that I'm sick you still manage to cheer me up";
                convText[2] = "Thanks honey";

                reactionDyl = "If it makes you feel better, I'm more than glad to to talk to you every day";
                convType = 3;
            }
            else if (line == 5)
            {
                convText[0] = "Thank you honey";
                convText[1] = "I do need some rest though now";
                convText[2] = "Thank you again for the tea, and sleep well tonight";

                momConvDone = true;
                mom.tag = "Untagged";
                convType = 1;
            }
        }
        else if (convName == "NeighbourConv1")
        {
            if (line == 1)
            {
                convText[0] = "Aaaah sometimes you have days like that";
                convText[1] = "So tell me chap, what happened?";
                convText[2] = "Maybe this old man can give you some life advice";

                choicesOptions[0] = "I'm going on a date tomorrow, but I'm a bit stressed and I don't think I'll be able to enjoy the date";
                choicesOptions[1] = "My mom apparently has a tumor and I don't know what to do";
                choicesOptions[2] = "Just something bad happened, but also something good, and now I don't know how to feel";
                choicesOptions[3] = "My day was going really well, but then I got some bad news from my dad, and now the good feels insignificant";

                convType = 2;

            }
            else if (line == 2)
            {
                neighbourConv1Choice1 = choiceMade;
                if (neighbourConv1Choice1 == 1)
                {
                    convText[0] = "A date? That sounds like fun!";
                    convText[1] = "If you're stressed you should try and enjoy the date as much as possible";
                    convText[2] = "Use it as a distraction so that you don't have to think about the thing that is causing you stress";
                }
                else if (neighbourConv1Choice1 == 2)
                {
                    convText[0] = "Your mom has a tumor? I'm sorry to hear that.";
                    convText[1] = "Don't worry though, your mom is a strong lady, she'll get through it";
                    convText[2] = "If you just stay positive you will make your mom happy, and her recovery will go smoother";
                }
                else if (neighbourConv1Choice1 == 3)
                {
                    convText[0] = "Ah so it's a bit of an emotional rollercoaster day I see";
                    convText[1] = "On those days it's best to sit down for a second and look back. Ask yourself, was the bad thing really that bad?";
                    convText[2] = "And most of the time you will find that the good thing will make you happier then the bad thing makes you sad";
                }
                else if (neighbourConv1Choice1 == 4)
                {
                    convText[0] = "Ah I see, that's very unfortunate";
                    convText[1] = "It might be a good idea to look back at the good thing";
                    convText[2] = "If it made you happy once, maybe it can make you feel really happy again";
                }
                reactionDyl = "That's actually really useful advice, thanks Mr. Rogers!";
                convType = 3;
            }
            else if (line == 3)
            {
                convText[0] = "Hahaha don't worry about it kid";
                convText[1] = "With age comes wisdom, and as you know, I am quite old";
                convText[2] = "And sharing that wisdom is a pleasure if it makes the people around me happier";

                choicesOptions[0] = "Where did you learn so much?";
                choicesOptions[1] = "Did you go on dates? When you were still young?";
                choicesOptions[2] = "Thanks for the conversation Mr. Rogers";
                choicesOptions[3] = "Have you ever had to deal with someone close to you getting really sick?";

                convType = 2;
            }
            else if (line == 4)
            {
                neighbourConv1Choice2 = choiceMade;
                if (neighbourConv1Choice2 == 1)
                {
                    convText[0] = "Life chap!";
                    convText[1] = "The more things you do and experience in life, the more you learn!";
                    convText[2] = "That's why you should go out and do fun things while you're still young!";
                }
                else if (neighbourConv1Choice2 == 2)
                {
                    convText[0] = "I did go on dates indeed!";
                    convText[1] = "That's how I met my lovely wife";
                    convText[2] = "Even though she may not be with us anymore today, I will forever be glad for the time we got to spent together.";
                }
                else if (neighbourConv1Choice2 == 3)
                {
                    convText[0] = "Don't thank me!";
                    convText[1] = "You know I like some conversation now and then, it gets lonely around here sometimes";
                    convText[2] = "So thank you for taking your time to come to talk to this old man";
                }
                else if (neighbourConv1Choice2 == 4)
                {
                    convText[0] = "Yes I did, unfortunately. When people get older they get more prone to being sick";
                    convText[1] = "And as I am quite old now, there are a lot of friends and relatives who have gotten sick.";
                    convText[2] = "However there is no need to stay sad about it, illness is a part of life, and life goes on. So we also need to move on";
                }
                reactionDyl = "Thank you for everything, but I really should go do my homework at some point";
                convType = 3;
            }
            else if (line == 5)
            {
                convText[0] = "Aah that's fine chap";
                convText[1] = "Homework is something that needs to be done, school is important";
                convText[2] = "Take care, and sleep well tonight Dylan";
                convType = 1;
                neighbourConvDone = true;
                neighbouryeet.tag = "Untagged";
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
