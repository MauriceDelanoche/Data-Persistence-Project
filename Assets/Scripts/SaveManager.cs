using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SaveManager : MonoBehaviour
{

    
    public TMP_InputField inputField;

    public string player_name;

    public static SaveManager Instance;

    public Text BestScore;

    
    

    private void Start()
    {
        BestScore.text = ("Best Score : " + PlayerPrefs.GetString("HighPlayerName", "xxx") + " :  " + PlayerPrefs.GetInt("HighScore", 0).ToString());

        
    }


    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SetPLayerName()
    {
        player_name = inputField.text;

        

    }

    public void DeleteData()
    {
        PlayerPrefs.DeleteKey("HighScore");
        PlayerPrefs.DeleteKey("HighPlayerName");

        

    }




}
