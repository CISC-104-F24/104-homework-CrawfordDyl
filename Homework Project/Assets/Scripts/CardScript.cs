using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardScript : MonoBehaviour
{
    // Changeable variables
    public int rank = 2;  // Default rank
    public string suit = "♥";  // Default suit
    public Color suitColor = Color.red;  // Default suit color

    // UI references
    public TextMeshProUGUI rankTextTopLeft;
    public TextMeshProUGUI rankTextBottomRight;
    public TextMeshProUGUI suitText;
    public TextMeshProUGUI suitTextTopLeft;
    public TextMeshProUGUI suitTextBottomRight;

    // Suit options
    private string[] suits = { "♥", "♦", "♣", "♠" };
    private int suitIndex = 0;  // Tracks the current suit index

    public void IncreaseRank()
    {
        Debug.Log("Increase Rank clicked");
        if (rank < 13)
        {
            rank++;
        }
        else
        {
            rank = 1; 
        }
        Debug.Log("Rank after increase: " + rank);
        UpdateCardDisplay();
    }

    public void DecreaseRank()
    {
        Debug.Log("Decrease Rank clicked");
        if (rank > 1)
        {
            rank--;
        }
        else
        {
            rank = 13; 
        }
        Debug.Log("Rank after decrease: " + rank);
        UpdateCardDisplay();
    }

    public void RandomRank()
    {
        Debug.Log("Random Rank clicked");
        rank = Random.Range(1, 14);  // Random rank between 1 and 13
        Debug.Log("New random rank: " + rank);
        UpdateCardDisplay();
    }

    public void ChangeSuit()
    {
        Debug.Log("Change Suit clicked");
        suitIndex = (suitIndex + 1) % suits.Length; 
        Debug.Log("Suit Index: " + suitIndex);
        suit = suits[suitIndex];
        UpdateCardDisplay();
    }

    public void ChangeSuitColor()
    {
        Debug.Log("Change Suit Color clicked");
        suitColor = new Color(Random.value, Random.value, Random.value);  // Random color
        Debug.Log("New Suit Color: " + suitColor);
        UpdateCardDisplay();
    }

    private void UpdateCardDisplay()
    {
        // Update rank texts
        rankTextTopLeft.text = rank.ToString();
        rankTextBottomRight.text = rank.ToString();

        // Update suit texts
        suitText.text = suit;
        suitTextTopLeft.text = suit;
        suitTextBottomRight.text = suit;

        // Update text colors
        suitText.color = suitColor;
        suitTextTopLeft.color = suitColor;
        suitTextBottomRight.color = suitColor;

        // Update rank colors
        rankTextTopLeft.color = suitColor;
        rankTextBottomRight.color = suitColor;

        Canvas.ForceUpdateCanvases();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
