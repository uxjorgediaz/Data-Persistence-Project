using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputFieldGrabber : MonoBehaviour
{
    [Header("The value we got from input field")]
    [SerializeField] public string inputText;


    [Header("showing reactection to the player")]
    [SerializeField] public TMP_Text reactionTextBox;


    public void GrabFromImputField (string input)
    {
        inputText = input;
        DisplayReactionToInput();

    }

    private void DisplayReactionToInput()
    {
        Debug.Log("the name of the player is " + inputText);



    }
}
