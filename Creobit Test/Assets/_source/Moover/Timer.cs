using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    float _currentTime;
    [SerializeField] private GameObject _FinishScreen;
    [SerializeField] private TMP_Text _score;
    [SerializeField] private TMP_Text _bestScore;
    [SerializeField] private SceneLoader _loader;
    void Update()
    {
        _currentTime += Time.deltaTime;

    }
  
    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.layer == 7)
        {
           
            _FinishScreen.gameObject.SetActive(true);
            _score.text = "Score = " + Mathf.RoundToInt(_currentTime) + " sec";

            if (PlayerPrefs.GetInt("Score") <= 0)
            {
               
                PlayerPrefs.SetInt("Score", Mathf.RoundToInt(_currentTime));
            }
           
            if (PlayerPrefs.GetInt("Score") > Mathf.RoundToInt(_currentTime))
            {
                PlayerPrefs.SetInt("Score", Mathf.RoundToInt(_currentTime));
            }
            _bestScore.text = "Best score = " + PlayerPrefs.GetInt("Score") + " sec";
        }
        if(collision.gameObject.layer == 8)
        {
            _loader.LoadWalker();
        }
    }
}
