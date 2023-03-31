using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Base_6 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI revisa;
    [SerializeField] private Color[] colors;
    private bool[] corrects;
    private bool[] incorrect;
    public bool base_6_completed = false;

    private void Awake()
    {
        revisa.alpha = 0f;
        corrects = new bool[3];
        incorrect = new bool[4];
    }

    public void Carro()
    {
        GameObject.Find("Carro").GetComponent<Image>().color = colors[Random.Range(0, 2)];
        incorrect[0] = true;
    }

    public void Amor()
    {
        GameObject.Find("Amor").GetComponent<Image>().color = colors[Random.Range(0, 2)];
        corrects[0] = true;
    }

    public void Ropa()
    {
        GameObject.Find("Ropa").GetComponent<Image>().color = colors[Random.Range(0, 2)];
        incorrect[1] = true;
    }

    public void Felicidad()
    {
        GameObject.Find("Felicidad").GetComponent<Image>().color = colors[Random.Range(0, 2)];
        corrects[1] = true;
    }

    public void Dulces()
    {
        GameObject.Find("Dulces").GetComponent<Image>().color = colors[Random.Range(0, 2)];
        incorrect[2] = true;
    }

    public void Mascotas()
    {
        GameObject.Find("Mascotas").GetComponent<Image>().color = colors[Random.Range(0, 2)];
        incorrect[3] = true;
    }

    public void Salud()
    {
        GameObject.Find("Salud").GetComponent<Image>().color = colors[Random.Range(0, 2)];
        corrects[2] = true;
    }

    public void Resetear()
    {
        corrects[0] = false;
        corrects[1] = false;
        corrects[2] = false;
        incorrect[0] = false;
        incorrect[1] = false;
        incorrect[2] = false;
        incorrect[3] = false;
        GameObject.Find("Carro").GetComponent<Image>().color = Color.white;
        GameObject.Find("Amor").GetComponent<Image>().color = Color.white;
        GameObject.Find("Ropa").GetComponent<Image>().color = Color.white;
        GameObject.Find("Felicidad").GetComponent<Image>().color = Color.white;
        GameObject.Find("Dulces").GetComponent<Image>().color = Color.white;
        GameObject.Find("Mascotas").GetComponent<Image>().color = Color.white;
        GameObject.Find("Salud").GetComponent<Image>().color = Color.white;
    }

    IEnumerator Revisar()
    {
        revisa.alpha = 1f;
        yield return new WaitForSeconds(3);
        revisa.alpha = 0f;
    }

    public void Comprobar()
    {
        if (incorrect[0] == true || incorrect[1] == true || incorrect[2] == true || incorrect[3] == false)
        {
            StartCoroutine(Revisar());
        }

        if (corrects[0] == true && corrects[1] == true && corrects[2] == true)
        {
            base_6_completed = true;
        }
    }
}
