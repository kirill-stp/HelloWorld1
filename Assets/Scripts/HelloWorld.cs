using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HelloWorld : MonoBehaviour
{
    #region variables

    public Text guessLabel;
    public Text attemptLabel;
    public SceneLoader sceneLoader;
    public int attempts = -1;
    public int guess; 
    public int initMin = 4;
    public int initMax = 1000;
    private int min;
    private int max;


    #endregion

    #region unity lifecycle
    // Start is called before the first frame update
    void Start()
    {
        Reset();
        UpdateInfo();
        DontDestroyOnLoad(gameObject);
    }
    
    #endregion

    #region public methods

    public void UpButtonPress()
    {
        min = guess;
        UpdateInfo();
    }

    public void DownButtonPress()
    {
        max = guess;
        UpdateInfo();
    }

    public void CorrectButtonPress()
    {
        sceneLoader.ChangeScene(2);
    }
    #endregion
    
    #region private methods
    private void UpdateInfo()
    {
        attempts++;
        guess = (min + max) / 2;
        guessLabel.text = $"Загадай число от {min} до {max}\nТвое число равно {guess}?";
        attemptLabel.text = $"Попыток потрачено: {attempts}";
    }

    private void Reset()
    {
        min = initMin;
        max = initMax;
    }

    #endregion
}
