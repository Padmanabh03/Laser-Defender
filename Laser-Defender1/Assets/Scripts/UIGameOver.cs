using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIGameOver : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    ScoreKeeper scoreKeeper;



    void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

   
    
    void Start()
    {
        text.text = "You Scored:\n" + scoreKeeper.GetScore();
    }

  
}
