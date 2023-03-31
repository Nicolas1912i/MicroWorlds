using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Base_4 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI revisa;
    [SerializeField] private GameObject inicio;
    [SerializeField] private GameObject actividad; 
    private bool checkThis = false;
    public bool base_4_completed = false;

    private void Awake()
    {
        inicio.SetActive(true);
        actividad.SetActive(false);
        revisa.alpha = 0f;
    }

    void Checks(int index0, int index1, int index2)
    {
        DropAlign[] dropAligns;
        dropAligns = new DropAlign[3];
        dropAligns[0] = GameObject.Find("Drp_4_0").GetComponent<DropAlign>();
        dropAligns[1] = GameObject.Find("Drp_4_1").GetComponent<DropAlign>();
        dropAligns[2] = GameObject.Find("Drp_4_2").GetComponent<DropAlign>();
        int[] values;
        values = new int[3];
        values[0] = 2;
        values[1] = 3;
        values[2] = 1;

        if (dropAligns[index0].currentValue == values[index0] && dropAligns[index1].currentValue == values[index1] && dropAligns[index2].currentValue == values[index2])
        {
            base_4_completed = true;
        }

        if (dropAligns[index0].currentValue != values[index0] || dropAligns[index1].currentValue != values[index1] || dropAligns[index2].currentValue != values[index2])
        {
            StartCoroutine(Revisar());
        }
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

    public void IrAlProblema()
    {
        inicio.SetActive(false);
        actividad.SetActive(true);
    }

    public void ReiniciarComponentes()
    {
        GameObject.Find("Depos").GetComponent<RectTransform>().anchoredPosition = new Vector3(GameObject.Find("Depos").GetComponent<AddValues>().position.x, GameObject.Find("Depos").GetComponent<AddValues>().position.y);
        GameObject.Find("Unid").GetComponent<RectTransform>().anchoredPosition = new Vector3(GameObject.Find("Unid").GetComponent<AddValues>().position.x, GameObject.Find("Unid").GetComponent<AddValues>().position.y);
        GameObject.Find("Med").GetComponent<RectTransform>().anchoredPosition = new Vector3(GameObject.Find("Med").GetComponent<AddValues>().position.x, GameObject.Find("Med").GetComponent<AddValues>().position.y);
        GameObject.Find("Drp_4_0").GetComponent<DropAlign>().currentValue = 0;
        GameObject.Find("Drp_4_1").GetComponent<DropAlign>().currentValue = 0;
        GameObject.Find("Drp_4_2").GetComponent<DropAlign>().currentValue = 0;
    }

    public void Comprobar()
    {
        StartCoroutine(Comprobacion());
        Checks(0,1,2);
    }

    public void VolverAlTexto()
    {
        inicio.SetActive(true);
        actividad.SetActive(false);
    }
}
