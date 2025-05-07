using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using Unity.VisualScripting;

public class SquareHighlighter : MonoBehaviour
{
    public Color highlightColor = Color.yellow;
    public Color defaultColor = Color.white;

    private List<Button> squareButtons = new List<Button>();
    private Button currentHighlighted;

    void Start()
    {
        GameObject[] squares = GameObject.FindGameObjectsWithTag("SquareButton");

        foreach (GameObject square in squares)
        {
            Button btn = square.GetComponent<Button>();
            if (btn != null)
            {
                squareButtons.Add(btn);
            }
        }
    }

    public void HighlightRandomSquare()
    {
        // Reset previous highlight
        if (currentHighlighted != null)
        {
            SetButtonColor(currentHighlighted, defaultColor);
        }

        if (squareButtons.Count == 0) return;

        // Choose a random square
        int index = Random.Range(0, squareButtons.Count);
        currentHighlighted = squareButtons[index];

        // Highlight it
        SetButtonColor(currentHighlighted, highlightColor);
    }

    void SetButtonColor(Button btn, Color color)
    {
        SpriteRenderer sprite = btn.transform.gameObject.GetComponent<SpriteRenderer>();
        sprite.color = color;
        Debug.Log("click detected");
         
    }
}
