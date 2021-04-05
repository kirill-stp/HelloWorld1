using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class RedEnemy : MonoBehaviour
{
    [SerializeField] private RedPlayer player;
    
    [SerializeField]private string playerName = "Вова";
    [SerializeField]private int attack = 6;
    [SerializeField]private int hp = 40;
    [SerializeField]private int pierce = 1;

    private int tempHp;

    [SerializeField]private Sprite sprite;
    [SerializeField]private Image image;
    [SerializeField]private TextMeshProUGUI nameText;
    [SerializeField]private TextMeshProUGUI hpText;

    public void TakeDamage(int damageValue)
    {
        if (damageValue < 0) damageValue = 0;
        tempHp -= damageValue;
        print($"Player deals {damageValue} damage to Enemy.\n{tempHp} hp left");
    }

    // Start is called before the first frame update
    void Start()
    {
        ResetValues();
        image.sprite = sprite;
        nameText.text = playerName;
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            player.TakeDamage(attack + pierce);
            player.UpdateUI();
        }
        if (Input.GetKeyDown(KeyCode.Space)) ResetValues();
    }

    public void UpdateUI()
    {
        hpText.text = tempHp.ToString();
    }
    private void ResetValues()
    {
        print("Restart");
        tempHp = hp;
        UpdateUI();
        player.UpdateUI();
    }
}
