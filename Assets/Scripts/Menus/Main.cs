using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    public GameObject mainScene;
    public GameObject selectPlayerScene;
    public GameObject modelBoy, modelGirl;

    void Start()
    {
        selectPlayerScene.SetActive(false);
        mainScene.SetActive(true);
        modelBoy.SetActive(false);
        modelGirl.SetActive(false);
    }

    public void selectPlayer()
    {
        mainScene.SetActive(false);
        selectPlayerScene.SetActive(true);
    }
}
