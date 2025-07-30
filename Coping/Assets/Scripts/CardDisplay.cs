using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Recordamur;

public class CardDisplay : MonoBehaviour
{

    public Card cardData;
    public Image cardImage;
    public TMP_Text nameText;
    public TMP_Text healthText;
    public TMP_Text staminaText;
    public TMP_Text rankText;
    public Sprite typeImage;
    public Sprite cardCentreImage;

    private Color[] cardColor =
    {
        new Color(0.74f, 0.28f, 0.28f),
        // Attacker
        new Color(0.41f, 0.75f, 0.37f),
        // Buffer
        new Color(0.51f, 0.61f, 1.00f),
        // Elemental
        new Color(0.46f, 0.24f, 0.60f),
        // Psycher
        new Color(0.87f, 0.76f, 0.00f)
        // Trickster

    };


    void Start()
    {
        UpdateCardDisplay();
    }

    public void UpdateCardDisplay()
    {

        cardImage.color = cardColor[(int)cardData.cardType[0]];
        nameText.text = cardData.cardName;
        healthText.text = cardData.health.ToString();
        staminaText.text = cardData.stamina.ToString();
        rankText.text = cardData.masteryRank + " Mastery";
        typeImage = cardData.type;
        cardCentreImage = cardData.Sprite;

    }
}
