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
    public Image[] typeImages;


    void Start()
    {
        UpdateCardDisplay();
    }

    public void UpdateCardDisplay()
    {
        nameText.text = cardData.cardName;
        healthText.text = cardData.health.ToString();
        staminaText.text = cardData.stamina.ToString();
        rankText.text = cardData.masteryRank;

    }
}
