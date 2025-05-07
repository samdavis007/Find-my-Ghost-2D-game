using UnityEngine;

public class TestClick : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);

            if (hit.collider != null)
            {
                Debug.Log("Clicked on: " + hit.collider.name);
            }
            else
            {
                Debug.Log("Clicked nothing");
            }
        }
    }
}
