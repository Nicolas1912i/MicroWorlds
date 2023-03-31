using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectPlayer : MonoBehaviour
{
    
    public Player playerScript;
    public bool[] playerSelectedBoy;
    public bool[] playerSelectedGirl;
    public GameObject modelsBoys;
    public GameObject playersBoysButtons;
    public GameObject playersGirlsButtons;
    public GameObject modelsGirls;
    public GameObject inputName;
    public GameObject buttonOK;
    public GameObject selectSexButton;
    [HideInInspector] public bool nameSet = false;
    [HideInInspector] public int character = 7;
    [HideInInspector] public int characterSex = 7;
    public InputField enterPlayerName;

    void Start()
    {
        
        playersBoysButtons.SetActive(false);
        playersGirlsButtons.SetActive(false);
        modelsBoys.SetActive(false);
        modelsGirls.SetActive(false);
        buttonOK.SetActive(false);
        selectSexButton.SetActive(true);
        inputName.SetActive(false);
    }

    void Update()
    {
        if (nameSet == true && enterPlayerName.text == "" && (playerSelectedBoy[0] == false || playerSelectedBoy[1] == false || playerSelectedBoy[2] == false || playerSelectedGirl[0] == false || playerSelectedGirl[1] == false || playerSelectedGirl[2] == false))
        {
            StartCoroutine(SomethingLeft());
        }
    }

    void FixedUpdate()
    {
        if (nameSet == true && enterPlayerName.text != "" && (playerSelectedBoy[0] == true || playerSelectedBoy[1] == true || playerSelectedBoy[2] == true || playerSelectedGirl[0] == true || playerSelectedGirl[1] == true || playerSelectedGirl[2] == true))
        {
            SaveSystem.SavePlayer(playerScript);
        }
    }

    public void ImBoy()
    {
        selectSexButton.SetActive(false);
        characterSex = 1;
        inputName.SetActive(true);
        modelsBoys.SetActive(true);
        buttonOK.SetActive(true);
        playersBoysButtons.SetActive(true);
    }

    public void ImGirl()
    {
        selectSexButton.SetActive(false);
        characterSex = 2;
        inputName.SetActive(true);
        modelsGirls.SetActive(true);
        buttonOK.SetActive(true);
        playersGirlsButtons.SetActive(true);
    }

    public void SetFinishPlayer()
    {
        SceneManager.LoadScene(1);
        nameSet = true;      
    }

    public void SelectPrefabPlayerBoy(int PlayerSelected)
    {
        playerSelectedBoy[0] = false;
        playerSelectedBoy[1] = false;
        playerSelectedBoy[2] = false;
        playerSelectedBoy[PlayerSelected] = true;
        character = PlayerSelected;    
    }

    public void SelectPrefabPlayerGirl(int PlayerSelected)
    {
        playerSelectedGirl[0] = false;
        playerSelectedGirl[1] = false;
        playerSelectedGirl[2] = false;
        playerSelectedGirl[PlayerSelected] = true;
        character = PlayerSelected;     
    }

    IEnumerator SomethingLeft()
    {
        yield return new WaitForEndOfFrame();
        enterPlayerName.GetComponentInChildren<Text>().text = "Falta algo";
    }
}
