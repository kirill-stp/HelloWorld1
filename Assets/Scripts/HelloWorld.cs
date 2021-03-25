using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{

    private int min = 4;
    private int max = 1000;
    private int guess; 
    
    // Start is called before the first frame update
    void Start()
    {
        print($"Загадай число от {min} до {max}");
        guess = (min + max) / 2;
        print($"Твое число равно {guess}?");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (min + max) / 2;
            print($"Твое число равно {guess}?");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (min + max) / 2;
            print($"Твое число равно {guess}?");            
        }
        if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {
            print("Конец игры");
        }
    }
}
