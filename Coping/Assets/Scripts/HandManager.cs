using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Recordamur;
using System;

public class HandManager : MonoBehaviour
{
    public DeckManager deckManager;
    // Assign prefab in Inspector
    public GameObject cardPrefab;
    // Root of hand position
    public Transform handTransform;
    // Determine card spread
    public float fanSpread = 7.5f;
    // Determine space of card
    public float cardSpacing = -100f;

    public float verticalSpacing = 100f;

    public int maxHandSize = 5;

    // List of card objects in hand
    public List<GameObject> cardsInHand = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void AddCardToHand(Card cardData)
    {
        if (cardsInHand.Count < maxHandSize)
        {
         //Instantiate card
                GameObject newCard = Instantiate(cardPrefab, handTransform.position, Quaternion.identity, handTransform);
                cardsInHand.Add(newCard);

                //set CardData of instantiated card
                newCard.GetComponent<CardDisplay>().cardData = cardData; 
        }
       UpdateHandVisuals();
    }

    void Update()
    {
        UpdateHandVisuals();
    }

    private void UpdateHandVisuals()
    {
        int cardCount = cardsInHand.Count;

        if (cardCount == 1)
        {
            // If 1 card present, do not calculate a rotation angle or position offset
            cardsInHand[0].transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            cardsInHand[0].transform.localPosition = new Vector3(0f, 0f, 0f);
            return;
        }

        for (int i = 0; i < cardCount; i++)
        {
            //Calculate rotation angle
            float rotationAngle = (fanSpread * (i - (cardCount - 1) / 2f));
            // Set a rotation angle dynamically for each card based on the number of cards
            cardsInHand[i].transform.localRotation = Quaternion.Euler(0f, 0f, rotationAngle);
            // Calculate horizontal spacing
            float horizontalOffset = (cardSpacing * (i - (cardCount - 1) / 2f));
            //Normalize card position between -1 and 1
            float normalizedPosition = (2f * i / (cardCount - 1) - 1f);
            //Calculate vertical spacing
            float verticalOffset = verticalSpacing * (1 - normalizedPosition * normalizedPosition);
            //Set final card positions
            cardsInHand[i].transform.localPosition = new Vector3(horizontalOffset, verticalOffset, 0f);
        }
    }
}
