using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World_1 : MonoBehaviour
{

    Base_1 base_1;
    Base_2 base_2;
    Base_3 base_3;
    Base_4 base_4;
    Base_5 base_5;
    [SerializeField] private GameObject startPanel;
    [SerializeField] private GameObject _1Activity;
    [SerializeField] private GameObject _2Activity;
    [SerializeField] private GameObject _3Activity;
    [SerializeField] private GameObject _4Activity;
    [SerializeField] private GameObject _5Activity;
    [SerializeField] private GameObject _6Activity;
    

    void Start()
    {
        base_1 = GameObject.Find("Base_1").GetComponent<Base_1>();
        base_2 = GameObject.Find("Base_2").GetComponent<Base_2>();
        base_3 = GameObject.Find("Base_3").GetComponent<Base_3>();
        base_4 = GameObject.Find("Base_4").GetComponent<Base_4>();
        base_5 = GameObject.Find("Base_5").GetComponent<Base_5>();
        startPanel.SetActive(true);
        _1Activity.SetActive(false);
        _2Activity.SetActive(false);
        _3Activity.SetActive(false);
        _4Activity.SetActive(false);
        _5Activity.SetActive(false);
        _6Activity.SetActive(false);
    }

    public void Start_1()
    {
        startPanel.SetActive(false);
        _1Activity.SetActive(true);
    }

    void FixedUpdate()
    {
        if (base_1.base_1_completed == true)
        {
            startPanel.SetActive(false);
            _1Activity.SetActive(false);
            _2Activity.SetActive(true);
        }

        if (base_2.base_2_completed == true)
        {
            _2Activity.SetActive(false);
            _3Activity.SetActive(true);
        }

        if (base_3.base_3_completed == true)
        {
            _3Activity.SetActive(false);
            _4Activity.SetActive(true);
        }

        if (base_4.base_4_completed == true)
        {
            _4Activity.SetActive(false);
            _5Activity.SetActive(true);
        }

        if (base_5.base_5_completed == true)
        {
            _5Activity.SetActive(false);
            _6Activity.SetActive(true);
        }
    }
}
