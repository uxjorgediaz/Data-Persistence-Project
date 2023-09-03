using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{

    [SerializeField] private TMP_InputField inputField;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StartNew()
    {


        SceneManager.LoadScene(1);

    }

    public void GetInputField()
    {
        if (inputField != null)
        {
            string inputText = inputField.text;

          //  Debug.Log("input text; " + inputText);

            DataPasser.Instance.playerName = inputText;
        }

        else
        {

          //  Debug.LogError("Input is not assignend.");
        }


    }


public void Quit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }

   

}
