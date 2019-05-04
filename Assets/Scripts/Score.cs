using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [Header("Debug")]
    [SerializeField] private Text scoreTextReference = null;
    [SerializeField] private float counter = 0f;
    
    public void AddScore(float scoreToAdd = 1f)
    {
        counter += scoreToAdd;
        scoreTextReference.text = counter.ToString();
    }
}
