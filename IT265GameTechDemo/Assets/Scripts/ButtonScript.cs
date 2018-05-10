using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public GameObject playerOne, playerTwo;

    public Toggle playerOneSelect, playerTwoSelect;
    public Text textBox;
    public Text playerOneHoldReal, playerOneHoldFake, playerTwoHoldReal, playerTwoHoldFake;
    Text realWords1, fakeWords1, realWords2, fakeWords2;
    public Toggle setReal, setFake;
    int realPoints = 0;
    int fakePoints = 0;
    public Text wordsChosen;

	void Start ()
    {
        realWords1 = playerOneHoldReal.GetComponent<Text>();
        realWords2 = playerTwoHoldReal.GetComponent<Text>();
        fakeWords1 = playerOneHoldFake.GetComponent<Text>();
        fakeWords2 = playerTwoHoldFake.GetComponent<Text>();
    }

    public void CheckForPoints()
    {
        if(setReal.isOn == false && setFake.isOn == false)
        {
            wordsChosen.text += "\n" + textBox.text;
            this.gameObject.SetActive(false);
        }
    }

    public void AddWordToPlayerBox()
    {
        if (playerOneSelect.isOn == true)
        {
            if (setReal.isOn == true)
            {
                realWords1.text += "\n" + textBox.text;
            }
            else if(setFake.isOn == true)
            {
                fakeWords1.text += "\n" + textBox.text;
            }
        }
        else if (playerTwoSelect.isOn == true)
        {
            if (setReal.isOn == true)
            {
                realWords2.text += "\n" + textBox.text;
            }
            else if(setFake.isOn == true)
            {
                fakeWords2.text += "\n" + textBox.text;
            }
        }
    }

    public void ClearEverything()
    {
        wordsChosen.text = "Words Used So Far: \n";
        realWords1.text = " ";
        realWords2.text = " ";
        fakeWords1.text = " ";
        fakeWords2.text = " ";
    }
}
