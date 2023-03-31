using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Base_2 : MonoBehaviour
{
    private DropPoint dropPoint;
    [SerializeField] private TextMeshProUGUI moneyCount;
    [SerializeField] private TextMeshProUGUI aunFalta;
    [SerializeField] private GameObject inicio;
    [SerializeField] private GameObject actividad;
    [SerializeField] private GameObject[] articulos;
    [SerializeField] private bool checkThis = false;
    public bool base_2_completed = false;

    private void Awake()
    {
        dropPoint = FindObjectOfType<DropPoint>().GetComponent<DropPoint>();
        inicio.SetActive(true);
        actividad.SetActive(false);
        aunFalta.alpha = 0f;
    }

    IEnumerator Comprobacion()
    {
        checkThis = true;
        yield return new WaitForFixedUpdate();
        checkThis = false;
    }

    IEnumerator YouDidIt()
    {
        dropPoint.currentValue = 0;
        moneyCount.alpha = 0f;
        yield return new WaitForSeconds(3);
        moneyCount.alpha = 1f;
        yield return new WaitForEndOfFrame();
    }

    IEnumerator NotEnough()
    {
        moneyCount.alpha = 0f;
        aunFalta.alpha = 1f;
        yield return new WaitForSeconds(3);
        moneyCount.alpha = 1f;
        aunFalta.alpha = 0f;
    }

    private void Update()
    {
        moneyCount.text = "$ " + dropPoint.currentValue;

        if (articulos[0].activeSelf == true)
        {
            Checks(0);
        }

        if (articulos[1].activeSelf == true)
        {
            Checks(1);
        }

        if (articulos[2].activeSelf == true)
        {
            Checks(2);
        }

        if (articulos[3].activeSelf == true)
        {
            Checks(3);
        }

        if (articulos[4].activeSelf == true)
        {
            if (checkThis == true && dropPoint.currentValue == 85950)
            {
                StartCoroutine(YouDidIt());
                articulos[4].SetActive(false);
                base_2_completed = true;
            }

            if (checkThis == true && dropPoint.currentValue != 85950)
            {
                aunFalta.text = "Falta $ " + (85950 - dropPoint.currentValue);
                StartCoroutine(NotEnough());
            }
        }
    }

    private void Checks(int index)
    {
        int[] value;
        value = new int[4];
        value[0] = 58350;
        value[1] = 68400;
        value[2] = 31000;
        value[3] = 18750;

        if (checkThis == true && dropPoint.currentValue == value[index])
        {
            articulos[index].SetActive(false);
            StartCoroutine(YouDidIt());
            articulos[index + 1].SetActive(true);
        }

        if (checkThis == true &&  dropPoint.currentValue != value[index])
        {
            aunFalta.text = "Falta $ " + (value[index] - dropPoint.currentValue);
            StartCoroutine(NotEnough());
        }
    }

    public void IrAlProblema()
    {
        inicio.SetActive(false);
        actividad.SetActive(true);
        articulos[0].SetActive(true);
        articulos[1].SetActive(false);
        articulos[2].SetActive(false);
        articulos[3].SetActive(false);
        articulos[4].SetActive(false);
    }

    public void Comprobar()
    {
        StartCoroutine(Comprobacion());
    }

    public void ReiniciarCartera()
    {
        dropPoint.currentValue = 0;
    }
}
