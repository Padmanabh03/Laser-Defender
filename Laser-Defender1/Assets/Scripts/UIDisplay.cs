using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIDisplay : MonoBehaviour
{
    [Header("Score")]
    [SerializeField] TextMeshProUGUI text;
    ScoreKeeper scoreKeeper;

    [Header("Health")]
    [SerializeField] Slider slider;
    [SerializeField] Health health;
    
    

    void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = health.GetHealth();    
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = health.GetHealth();
        text.text = scoreKeeper.GetScore().ToString("0000000");
    }
}
