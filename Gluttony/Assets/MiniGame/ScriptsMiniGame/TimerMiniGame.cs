using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using TMPro;

public class TimerMiniGame : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] Text TimerTextUI;
    [SerializeField] AudioSource audio;
     public int GameTime = 10; //время игры 
        int _currentTime = 0;//сколько прошло 

    void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
        panel.SetActive(false); 
        Time.timeScale = 1; 
        InvokeRepeating("Timer", 0, 1); 
    }

  
    void Update()
    {
        
    }
    void Timer() 

    { 

        _currentTime++; 
        if(_currentTime > GameTime) 

        { 
           panel.SetActive(true); 
           audio.Play();
            Time.timeScale = 0; 
        } 
        else 

        { 
           TimerTextUI.text = "0:0"+(GameTime - _currentTime).ToString(); 
        } 

    } 

    
}
