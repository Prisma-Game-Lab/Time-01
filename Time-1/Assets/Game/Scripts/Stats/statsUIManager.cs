using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class statsUIManager : MonoBehaviour
{
    public TextMeshProUGUI attack_txt;
    public TextMeshProUGUI velocity_txt;
    public TextMeshProUGUI defense_txt;

    private playerStats playerStats;


    void Start()
    {
        playerStats = GameObject.FindGameObjectWithTag("persistentData").GetComponent<playerStats>();
        setPlayerStats();
    }

    private void setPlayerStats()
    {
        attack_txt.text = "" + playerStats.attack;
        velocity_txt.text = "" + playerStats.velocity;
        defense_txt.text = "" + playerStats.defense;
    }
}
