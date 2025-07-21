using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Recordamur;
using System;

public class HandManager : MonoBehaviour
{
    // Assign prefab in Inspector
    public GameObject cardPrefab;
    // Root of hand position
    public Transform handTransform;
    // Determine card spread
    public float fanSpread = 7.5f;
    // Determine space of card
    public float cardSpacing = 100f;

    public float verticalSpacing = 10f;
    // List of card objects in hand
    public List<GameObject> cardsInHand = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        AddCardToHand();
        AddCardToHand();
        AddCardToHand();
        AddCardToHand();
        AddCardToHand();
        AddCardToHand();
    }

    public void AddCardToHand()
    {
        //Instantiate card
        GameObject newCard = Instantiate(cardPrefab, handTransform.position, Quaternion.identity, handTransform);
        cardsInHand.Add(newCard);

        UpdateHandVisuals();
    }

    void Update()
    {
        UpdateHandVisuals();
    }

    private void UpdateHandVisuals()
    {
        int cardCount = cardsInHand.Count;
        for (int i = 0; i < cardCount; i++)
        {
            float rotationAngle = (fanSpread * (i - (cardCount - 1) / 2f));
            cardsInHand[i].transform.localRotation = Quaternion.Euler(0f, 0f, rotationAngle);

            float horizontalOffset = i * (cardSpacing * (i - (cardCount - 1) / 2f));
            float verticalOffset = i * (verticalSpacing * (i - (cardCount - 1) / 2f));
            cardsInHand[i].transform.localPosition = new Vector3(horizontalOffset, verticalOffset, 0f);
        }
    }
}
