using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RedPlayer : MonoBehaviour
{
    [SerializeField] private RedEnemy enemy;
    
    [SerializeField]private string enemyName = "Вася Пупкин";
    [SerializeField]private int attack = 5;
    [SerializeField]private int hp = 50;
    [SerializeField]private int defence = 2;
    
    private int tempHp;

    [SerializeField]private Sprite sprite;
    [SerializeField]private Image image;
    [SerializeField]private TextMeshProUGUI nameText;
    [SerializeField]private TextMeshProUGUI hpText;

    public void TakeDamage(int damageValue)
    {
        int damage = damageValue - defence;
        if (damage < 0) damage = 0;
        tempHp -= damage;
        print($"Enemy deals {damage} damage to Player.\n{tempHp} hp left");
    }

    // Start is called before the first frame update
    void Start()
    {
        ResetValues();
        image.sprite = sprite;
        nameText.text = enemyName;
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            enemy.TakeDamage(attack);
            enemy.UpdateUI();
        }
        if (Input.GetKeyDown(KeyCode.Space)) ResetValues();
    }
    
    public void UpdateUI()
    {
        hpText.text = tempHp.ToString();
    }

    private void ResetValues()
    {
        tempHp = hp;
        UpdateUI();
        enemy.UpdateUI();
    }
}
