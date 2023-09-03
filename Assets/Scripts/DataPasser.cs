using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPasser : MonoBehaviour
{
    public static DataPasser Instance;

    public string playerName;

    private void Awake()
    {
        if(Instance!=null)
        {
            Destroy(gameObject);
            return;

        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

    }

    public void Update()
    {
       // Debug.Log("the name of the player is " + playerName);
    }



}
