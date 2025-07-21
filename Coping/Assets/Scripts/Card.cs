using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

namespace Recordamur
{
    [CreateAssetMenu(fileName = "New Card", menuName = "Card")]
    public class  Card : ScriptableObject
    {
        public string cardName;
        public List<CardType> cardType;
        public int health;
        public int stamina;
        public string masteryRank;
        public Sprite Sprite;
        public Sprite type;
    }

    public enum CardType
    {
        Attacker, 

        Buffer,

        Elemental,

        Psycher,

        Trickster,

        Unusual,

        God
    }
}