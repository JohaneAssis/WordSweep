using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatBox : MonoBehaviour
{
    public InputField chatInput;
    public Text chatBox;
    
    public Toggle playerOneSelected, playerTwoSelected;
    public Text chatBoxLog;

    public void AddToChatBox()
    {

        if (playerOneSelected.isOn == true)
        {
            chatBox.text += "\n Player 1: " + chatInput.text;
            chatBoxLog.text += "\n Player 1: " + chatInput.text;
        }
        else if (playerTwoSelected.isOn == true)
        {
            chatBox.text += "\n Player 2: " + chatInput.text;
            chatBoxLog.text += "\n Player 2: " + chatInput.text;
        }
    }

    public void ClearInput()
    {
        chatInput.text = "";
    }

    public void ClearChatBox()
    {
        chatBox.text = "";
    }

    public void ClearChatBoxLog()
    {
        chatBoxLog.text = "Chat Box Log: \n";
    }
}
