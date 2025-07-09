using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Recordamur
{
    [CreateAssetMenu(fileName = "New Card", menuName = "Card")]
    public class  Card : ScriptableObject
    {
        public string cardName;
        public List<CardType> cardType;
        public int health;
        public int stamina;
        public List<MasteryRank> masteryRank;
        public Sprite Sprite;
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

    public enum MasteryRank
    {
        Noble,

        S,

        A,

        B,

        C,

        D,

        E,

        F
    }
}