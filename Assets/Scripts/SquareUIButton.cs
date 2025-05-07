using UnityEngine;
using UnityEngine.UI;

public class SquareUIButton : MonoBehaviour
{
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnSquareClicked);
    }

    void OnSquareClicked()
    {
        Debug.Log("UI Button Clicked: " + gameObject.name);
    }
}
