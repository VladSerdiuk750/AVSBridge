using System;
using UnityEngine;

 public class Card : MonoBehaviour
 {
     [SerializeField] private int Value;

     [SerializeField] private CardSuits Suit;

     [SerializeField] private bool IsPlayed;

     [SerializeField] private bool isPlayable;
     
     

     private void OnMouseDown()
     {
         Debug.Log($"Suit: {Suit}, Value: {Value}");
     }
     
 }