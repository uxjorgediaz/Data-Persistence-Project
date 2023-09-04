using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using System.IO;

public class MenuUIHandler : MonoBehaviour
{

    [SerializeField] private TMP_InputField inputField;
    public TMP_Text bestScore;
    [SerializeField] int maximoHigthScore;
    [SerializeField] string playerNameHighScore;



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
    void MaxScore()
    {
        LoadData();

        bestScore.text = "Best Score : " + playerNameHighScore + " : " + maximoHigthScore;

    }
    [System.Serializable]
    class SaveData
    {
        public string playerName;
        public int maxPoints = 0;

    }

    public void LoadData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {

            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);


            maximoHigthScore = data.maxPoints;
            playerNameHighScore = data.playerName;


        }

    }
}