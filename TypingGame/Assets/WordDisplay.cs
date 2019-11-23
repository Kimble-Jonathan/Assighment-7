using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{

    public Dropdown dropdown;
    public static Color Color;
    public Slider speedSlider;
    public Text speedSliderTxt;


    public void Choice()
    {

        

        if (dropdown.value == 0)
            Color = Color.red;
        else if (dropdown.value == 1)
            Color = Color.blue;
        else if (dropdown.value == 2)
            Color = Color.white;
        else
            Color = Color.white;


        
    }

    public Text text1;
    public void COLOR()
    {
        text1.color = Color;
    }



    public Text text;
    public float fallSpeed;
    public void SetWord(string word)
    {
        text.text = word;

    }

    public void RemoveLetter()
    {
        text.text = text.text.Remove(0,1);
        text.color =Color;

    }

    public static int WordCounter = 0;
    public Text WordCounterTxt ;
    public void RemoveWord()
    {
        Destroy(gameObject);
       
    }
    private void Start()
    {
        fallSpeed = PlayerPrefs.GetFloat("speed", 1f);
        Choice();
        
    }
    public void Speed()
    {
        float sliderSpeed=speedSlider.value;
        PlayerPrefs.SetFloat("speed", sliderSpeed);
        speedSliderTxt.text = speedSlider.value.ToString("0.0");
    }
    private void Update()
    {
        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0);
        COLOR();

        Debug.Log(speedSlider.value);
        
    }
    
}
