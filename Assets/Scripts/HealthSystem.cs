using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using System.Collections.Generic;

public class ClickHealthSystem : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    public TextMeshProUGUI healthText;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthUI();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject clickedObject = GetClickedUIObject();

            if (clickedObject != null)
            {
                // ✅ Do NOT decrease health if clicked object has "SquareButton" tag
                if (!clickedObject.CompareTag("SquareButton"))
                {
                    DecreaseHealth(10);
                }
            }
            else
            {
                // Clicked outside of UI completely
                DecreaseHealth(10);
            }
        }
    }

    void DecreaseHealth(int amount)
    {
        currentHealth -= amount;
        currentHealth = Mathf.Max(currentHealth, 0);
        UpdateHealthUI();
    }

    void UpdateHealthUI()
    {
        if (healthText != null)
        {
            healthText.text = "Health: " + currentHealth;
        }
    }

    GameObject GetClickedUIObject()
    {
        PointerEventData pointerData = new PointerEventData(EventSystem.current)
        {
            position = Input.mousePosition
        };

        List<RaycastResult> raycastResults = new List<RaycastResult>();
        EventSystem.current.RaycastAll(pointerData, raycastResults);

        if (raycastResults.Count > 0)
            return raycastResults[0].gameObject;

        return null;
    }
}
