using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{

    public int character;
    public int characterSex;
    public string playerName;

    public PlayerData(Player player)
    {
        character = player.selectedCharacter;
        characterSex = player.selectedSex;
        playerName = player.playerName;
    }
}
