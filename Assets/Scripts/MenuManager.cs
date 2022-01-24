using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuManager : MonoBehaviour
{

    //BoutonSound
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        
        SceneManager.LoadScene(1);
        
    }

    public void Exit()
    {
        
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
        
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }

    public void BackToMenu()
    {
        
        SceneManager.LoadScene(0);
        
    }

}
