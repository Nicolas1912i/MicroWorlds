using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Base_1 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI header;
    [SerializeField] private TextMeshProUGUI revisa;
    [SerializeField] private TextMeshProUGUI escribe;
    [SerializeField] private GameObject inicio;
    [SerializeField] private GameObject problema;
    [SerializeField] private InputField chocolate;
    [SerializeField] private InputField harina;
    [SerializeField] private InputField azucar;
    public bool base_1_completed = false;
    private bool checkThis = false;

    void Awake()
    {
        inicio.SetActive(true);
        problema.SetActive(false);
        revisa.alpha = 0f;
        escribe.alpha = 0f;
    }

    public void IrAlProblema()
    {
        header.text = "Problema";
        inicio.SetActive(false);
        problema.SetActive(true);
    }

    IEnumerator Comprobacion()
    {
        checkThis = true;
        yield return new WaitForFixedUpdate();
        checkThis = false;
    }

    IEnumerator Revisar()
    {
        revisa.alpha = 1f;
        yield return new WaitForSeconds(3);
        revisa.alpha = 0f;
    }

    IEnumerator Escribe()
    {
        escribe.alpha = 1f;
        yield return new WaitForSeconds(3);
        escribe.alpha = 0f;
    }

    void Update()
    {
        if (checkThis == true && (chocolate.text == "" || harina.text == "" || azucar.text == ""))
        {
            StartCoroutine(Escribe());
        }

        if (checkThis == true && (chocolate.text != "8" || harina.text != "24" || azucar.text != "6"))
        {
            StartCoroutine(Revisar());
        }

        if (checkThis == true && (chocolate.text == "8" && harina.text == "24" && azucar.text == "6"))
        {
            base_1_completed = true;
        }
    }

    public void VolverAlTexto()
    {
        header.text = "Trueque";
        inicio.SetActive(true);
        problema.SetActive(false);
        revisa.alpha = 0f;
        escribe.alpha = 0f;
    }

    public void Comprobar()
    {
        StartCoroutine(Comprobacion());
    }
}
