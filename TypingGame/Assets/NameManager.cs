using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NameManager : MonoBehaviour
{
    public Text Name;
    public InputField input;
    public static string PlayerName = "";
    
  
    void Update()
    {
        Name.text = PlayerPrefs.GetString(PlayerName, "Enter Name");
    }

  
    public void Nametxt()
    {
        
        Name.text = input.text;
        PlayerName = Name.text;
        PlayerPrefs.SetString(PlayerName, Name.text);
    }
}
