using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.IO;

public class GameManager : MonoBehaviour
{
    public TextAsset textFile;
    string textFileToString;
    string[] words;
    string[] textStringToArray;
    public List<Text> texts;
    List<string> strings;
    public InputField chatBoxInput;
    public Text chatBox;

    //public GameObject textBoxObj;

    int point = 1;
    public Text playerOneRealScore, playerOneFakeScore, playerTwoRealScore, playerTwoFakeScore;

    void Awake()
    {
        GetWords();
        //Debug.Log(textFileToString);
        StringToArrayList();
        //Debug.Log(stringArrayToArrayList[Random.Range(0, 665)]);
        GetRandomWord();

    }

    //this would put the words into a string from the text file
    public void GetWords()
    {
        StreamReader reader = new StreamReader("./Assets/wordList.txt");
        string itemStrings = reader.ReadLine();

        while (itemStrings != null)
        {
            string[] words = itemStrings.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                textFileToString += words[i] + " ";
            }
            itemStrings = reader.ReadLine();
        }
    }

    //would make the string from the text file in a array to be used later
    public void StringToArrayList()
    {
        strings = new List<string>();
        textStringToArray = textFileToString.Split(',');
        strings.AddRange(textStringToArray);
        int l = strings.Count;
        for (int i = 0; i < l; i++)
        {
            if(strings[i] == null)
            {
                strings.RemoveAt(i);
            }
        }
    }

    ////gets a random word from the array list and makes sure that the next random word was not choosen before
    //public void GetRandomWord()
    //{
    //    for (int i = 0; i < 36; i++)
    //    {
    //        gameObject originalObj = textBoxObj.transform.Find("TextBox (" + i + ")").gameObject;
    //        if(originalObj != null)
    //        {
    //            Text aButton = originalObj.transform.Find("Button").GetComponentInChildren<Text>();
    //            aButton.text = strings[Random.Range(0, strings.Count)];
    //        }
    //    }
    //}

    public void GetRandomWord()
    {
        foreach (Text t in texts)
        {
            t.text = strings[Random.Range(0, strings.Count)];
        }
    }

    public void AddPointsPlayerOneRealPoints()
    {
        int score = int.Parse(playerOneRealScore.text);
        score += point;
        playerOneRealScore.text = score.ToString();
    }

    public void AddPointsPlayerOneFakePoints()
    {
        int score = int.Parse(playerOneFakeScore.text);
        score += point;
        playerOneFakeScore.text = score.ToString();
    }

    public void AddPointsPlayerTwoRealPoints()
    {
        int score = int.Parse(playerTwoRealScore.text);
        score += point;
        playerTwoRealScore.text = score.ToString();
    }

    public void AddPointsPlayerTwoFakePoints()
    {
        int score = int.Parse(playerTwoFakeScore.text);
        score += point;
        playerTwoFakeScore.text = score.ToString();
    }

    public void ResetScores()
    {
        playerOneRealScore.text = "0";
        playerOneFakeScore.text = "0";
        playerTwoRealScore.text = "0";
        playerTwoFakeScore.text = "0";
    }
}
