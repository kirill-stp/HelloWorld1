using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicNumbers : MonoBehaviour
{
    [SerializeField] private Text label;
    
    private int total;
    private int attempts = -1;
    [SerializeField] private int target = 50;
    
    private KeyCode[] buttons =
    {   KeyCode.Keypad0,
        KeyCode.Keypad1,
        KeyCode.Keypad2,
        KeyCode.Keypad3,
        KeyCode.Keypad4,
        KeyCode.Keypad5,
        KeyCode.Keypad6,
        KeyCode.Keypad7,
        KeyCode.Keypad8,
        KeyCode.Keypad9};

// Start is called before the first frame update
    void Start()
    {
        UpdateInfo();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            if (Input.GetKeyDown(buttons[i]))
            {
                total += i;
                UpdateInfo();
            }
        }

        if (total >= target) label.text = "Игра окончена!\nНажмите пробел чтобы начать заново";
        if (Input.GetKeyDown(KeyCode.Space))
        {
            total = 0;
            attempts = -1;
            UpdateInfo();
        }

    }

    void UpdateInfo()
    {
        attempts += 1;
        label.text = $"Нажмите цифру\nСумма: {total}\nПопыток затрачено: {attempts}";
    }
}
