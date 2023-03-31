using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Base_3 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI revisa;
    [SerializeField] private GameObject inicio;
    [SerializeField] private GameObject actividad;
    private bool checkThis = false;
    public bool base_3_completed = false;

    private void Awake()
    {
        inicio.SetActive(true);
        actividad.SetActive(false);
        revisa.alpha = 0f;
    }

    IEnumerator Comprobacion()
    {
        checkThis = true;
        yield return new WaitForSeconds(1);
        checkThis = false;
    }

    IEnumerator Revisar()
    {
        revisa.alpha = 1f;
        yield return new WaitForSeconds(3);
        revisa.alpha = 0f;
    }

    private void Checks(int index0, int index1, int index2, int index3, int index4, int index5)
    {
        DropPoint_4[] dropPoint_4s;
        dropPoint_4s = new DropPoint_4[6];
        dropPoint_4s[0] = GameObject.Find("Drp_0").GetComponent<DropPoint_4>();
        dropPoint_4s[1] = GameObject.Find("Drp_1").GetComponent<DropPoint_4>();
        dropPoint_4s[2] = GameObject.Find("Drp_2").GetComponent<DropPoint_4>();
        dropPoint_4s[3] = GameObject.Find("Drp_3").GetComponent<DropPoint_4>();
        dropPoint_4s[4] = GameObject.Find("Drp_4").GetComponent<DropPoint_4>();
        dropPoint_4s[5] = GameObject.Find("Drp_5").GetComponent<DropPoint_4>();
        int[] values;
        values = new int[6];
        values[0] = 3;
        values[1] = 2;
        values[2] = 1;
        values[3] = 3;
        values[4] = 1;
        values[5] = 2;

        if (dropPoint_4s[index0].currentValue == values[index0] && dropPoint_4s[index1].currentValue == values[index1] && dropPoint_4s[index2].currentValue == values[index2] && dropPoint_4s[index3].currentValue == values[index3] && dropPoint_4s[index4].currentValue == values[index4] && dropPoint_4s[index5].currentValue == values[index5])
        {
            base_3_completed = true;
        }
        if (dropPoint_4s[index0].currentValue != values[index0] || dropPoint_4s[index1].currentValue != values[index1] || dropPoint_4s[index2].currentValue != values[index2] || dropPoint_4s[index3].currentValue == values[index3] || dropPoint_4s[index4].currentValue != values[index4] || dropPoint_4s[index5].currentValue != values[index5])
        {
            StartCoroutine(Revisar());
        }
    }

    public void IrAlProblema()
    {
        inicio.SetActive(false);
        actividad.SetActive(true);
    }

    public void Comprobar()
    {
        StartCoroutine(Comprobacion());
        Checks(0,1,2,3,4,5);
    }

    public void VolverAlTexto()
    {
        inicio.SetActive(true);
        actividad.SetActive(false);
    }
}
