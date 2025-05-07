using UnityEngine;

public class GhostClick : MonoBehaviour
{
    void OnMouseDown()
    {
        Debug.Log("You clicked on: " + gameObject.name);
        gameObject.SetActive(false); // test effect
    }
}
