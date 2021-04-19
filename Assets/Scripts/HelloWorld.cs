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
    [SerializeField] private int min = 4;
    [SerializeField] private int max = 1000;
    private int attempts = -1;
    private int guess; 

    #endregion

    #region unity lifecycle
    // Start is called before the first frame update
    void Start()
    {
        UpdateInfo();
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

    #endregion
}
