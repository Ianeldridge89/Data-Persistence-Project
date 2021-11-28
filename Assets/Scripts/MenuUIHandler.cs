using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{

    public InputField playerNameInput;
    public string playerName;

    // Start is called before the first frame update

    public void NewNameSelected()
    {
        playerName = playerNameInput.text;
    }

    public string GetPlayerName()
    {
        return playerName;
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
        NewNameSelected();
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
