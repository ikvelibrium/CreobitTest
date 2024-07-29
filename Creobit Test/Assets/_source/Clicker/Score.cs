using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private int _pointsPerClick;
    [SerializeField] private TMP_Text text;
    private int _actualPoints = 0;
    private void Start()
    {
       
        if (PlayerPrefs.GetInt("Points") > _actualPoints)
        {
            _actualPoints = PlayerPrefs.GetInt("Points");
        }
        text.text = "Score " + _actualPoints;
    }
    public void AddPoints()
    {
        _actualPoints += _pointsPerClick;
        text.text = "Score " + _actualPoints;
        if (PlayerPrefs.GetInt("Points") < _actualPoints)
        {
            PlayerPrefs.SetInt("Points", _actualPoints);
        } 
    }
    
}
