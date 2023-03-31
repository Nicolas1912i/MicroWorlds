using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public SelectPlayer selectPlayer;
    public string playerName;
    public int selectedCharacter;
    public int selectedSex;


    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        //Establecer elementos que apareceran
        selectedCharacter = data.character;
        selectedSex = data.characterSex;
        playerName = data.playerName;
    }

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        selectedCharacter = selectPlayer.character;
        selectedSex = selectPlayer.characterSex;
        playerName = selectPlayer.enterPlayerName.text;
        Debug.Log("El personaje es " + selectedCharacter + " Y eres " + selectedSex + " Te llamas " + playerName);
    }
}
