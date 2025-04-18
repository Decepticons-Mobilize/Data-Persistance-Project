using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIHandlerMenu : MonoBehaviour
{
    public Button startButton;
    void Start()
    {
        startButton = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButtonClicked() 
    {
        SceneManager.LoadScene(1);
    }
    public void ExitButtonClicked() 
    {
        EditorApplication.ExitPlaymode();
    }
}
