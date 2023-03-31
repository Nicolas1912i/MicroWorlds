using UnityEngine;

public class AddValues : MonoBehaviour
{
    public int value;
    public GameObject gameObj;
    public Vector3 position;

    private void Awake()
    {
        position = new Vector3(this.GetComponent<RectTransform>().anchoredPosition.x, this.GetComponent<RectTransform>().anchoredPosition.y, 0f);
    }
}
