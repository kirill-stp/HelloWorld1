using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelloWorld : MonoBehaviour
{

    public Text label;
    [SerializeField] private int min = 4;
    [SerializeField] private int max = 1000;
    private int attempts = -1;
    private int guess; 
    
    // Start is called before the first frame update
    void Start()
    {
        UpdateInfo();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            UpdateInfo();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            UpdateInfo();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //что если изменили в юнити???
            min = 4;
            max = 1000;
            attempts = -1;
            UpdateInfo();
        }

        if (!Input.GetKeyDown(KeyCode.KeypadEnter) && !Input.GetKeyDown(KeyCode.Return)) return;
        
        label.text = $"Конец игры \nПопыток потрачено: {attempts}\nНажмите Пробел, чтобы начать заново";
    }

    void UpdateInfo()
    {
        attempts++;
        guess = (min + max) / 2;
        label.text = $"Загадай число от {min} до {max}\nТвое число равно {guess}?\n \nПопыток потрачено: {attempts}";
    }
}
