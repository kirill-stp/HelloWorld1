using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEnd : MonoBehaviour
{
    #region public variables

    public Text guessLabel;
    public Text attemptLabel;
    #endregion

    #region private variables

    private int attemts;
    private int guess;
    private HelloWorld helloWorldObject;

    #endregion

    #region unity lifecycle
    
    void Start()
    {
        helloWorldObject = FindObjectOfType<HelloWorld>();
        attemts = helloWorldObject.attempts;
        guess = helloWorldObject.guess;
        UpdateInfo();
    }

    #endregion

    #region private methods

    private void UpdateInfo()
    {
        guessLabel.text = $"Итоговое число:\n{guess.ToString()}";
        attemptLabel.text = $"Попыток потрачено:\n{attemts.ToString()}";
    }

    #endregion
}
