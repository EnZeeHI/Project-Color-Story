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


    public GameObject yesHomework;
    public GameObject noHomework;
    public GameObject image;
    public Text homeworkText;
    public GameObject homeworkCanvas;
    public GameObject homeworkPanel;

    public float countdown;
    public bool endTheGame;

    Scene currentScene;
    string sceneName;

    public Image faceHere;
    



    // added code for color change
    public bool personIsHappy;

    private void Update()
    {
        if (endTheGame == true)
        {
        //Debug.Log(countdown);

            if (countdown <= Time.time)
            {
                if (sceneName == "Tutorial")
                {
                    SceneManager.LoadScene("SampleScene");
                }
                else if (sceneName == "day2") 
                {
                    SceneManager.LoadScene("Exhibition");
                }
                else if (sceneName == "Exhibition")
                {
                    SceneManager.LoadScene("Main menu");
                }
                else if (sceneName == "School")
                {
                    SceneManager.LoadScene("SchoolAfterClass");
                }
                else
                {
                    SceneManager.LoadScene("day2");
                }
                
                
            }
        }
        //Debug.Log(sentences.Count);
    }
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();

        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;

    }

    public void StartDialouge (Dialouge dialouge)
    {

        nameText.text = dialouge.name;

        sentences.Clear();

        faceHere.sprite = dialouge.face.sprite;

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
        dialougeText.text = "End of day 13.";
        endTheGame = true;
        countdown = Time.time + 10;

        if (sceneName == "Tutorial")
        {
            dialougeText.text = "End of the tutorial, starting game";
        }
        else if (sceneName == "day2")
        {
            dialougeText.text = "Traveling to exhibition";
        }
        else if (sceneName == "Exhibition")
        {
            dialougeText.text = "Going home";
        }
        else if (sceneName == "School")
        {
            dialougeText.text = "Listening to the teacher";
        }
        //SceneManager.LoadScene("Credits Scene");
    }
    public void DoHomework()
    {
        //dialougeText.text = "Maybe I should do some homework";
        yesHomework.SetActive(false);
        noHomework.SetActive(false);
        image.SetActive(true);
        homeworkText.text = "";
        homeworkPanel.SetActive(false);

    }
    public void dontDoHomework()
    {
        yesHomework.SetActive(false);
        noHomework.SetActive(false);
        image.SetActive(false);
        homeworkCanvas.SetActive(false);
        homeworkPanel.SetActive(false);
    }
    public void activateHomeworkPrompt()
    {
        homeworkText.text = "Maybe I should do some homework";
        homeworkCanvas.SetActive(true);
        //homeworkText.SetActive(true);
         yesHomework.SetActive(true);
        noHomework.SetActive(true);
        homeworkPanel.SetActive(true);
    }

}
