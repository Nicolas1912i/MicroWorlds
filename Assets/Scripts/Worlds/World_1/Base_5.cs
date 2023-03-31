using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Base_5 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI revisa;
    [SerializeField] private GameObject inicio;
    [SerializeField] private GameObject actividad;
    public bool base_5_completed = false;

    private void Awake()
    {
        inicio.SetActive(true);
        actividad.SetActive(false);
        revisa.alpha = 0f;
    }

    public void Super1()
    {
        base_5_completed = true;
    }

    public void Super2()
    {
        StartCoroutine(Revisar());
    }

    IEnumerator Revisar()
    {
        revisa.alpha = 1f;
        yield return new WaitForSeconds(3);
        revisa.alpha = 0f;
    }

    public void VolverAlTexto()
    {
        inicio.SetActive(true);
        actividad.SetActive(false);
    }

    public void IrAlProblema()
    {
        inicio.SetActive(false);
        actividad.SetActive(true);
    }
}