using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class WordManager : MonoBehaviour
{
    public List<Word> words;

    public WordSpawner wordSpawner;

    public AudioSource mySound;
    private bool hasActiveWord;
    private Word activeWord;

    private string fileContents;
    public string[] wordsArray = { };

    public string GetRandomWord()
    {

        int randomIndex = Random.Range(0, wordsArray.Length);
        string randomWord = wordsArray[randomIndex];
       
       
        return randomWord;
       
    }
   
    public void AddWord ()
    {
        
        Word word = new Word(GetRandomWord(), wordSpawner.SpawnWord());
        
        
        words.Add(word);
        Debug.Log(word.word);

    }
    public Text WordCounterTxt;
    public int WordCounter = 0;
    public static int WordCounter2 = 0;
    public Text SaveWordCount;
    public Text LastWordCount;
    private void Start()
    {
        string path = "Assets/Words.txt";

        fileContents = "";

        string[] readText = File.ReadAllLines(path);
        foreach (string s in readText)
        {
            fileContents += s + "\n";
            
        }
        wordsArray = fileContents.Split(',');
        WordCounterTxt.text = "0";
       
        SaveWordCount.text =  PlayerPrefs.GetInt(NameManager.PlayerName, 0).ToString();

    }
   
    public void Typeletter(char letter)
    {
        if (hasActiveWord)
        {
            if (activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();

            }
        }
        else
        {
            foreach (Word word in words)
            {
                if (word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }
        if (hasActiveWord&& activeWord.WordTyped())
        {
            hasActiveWord = false;
            words.Remove(activeWord);
            WordCounter++;
            WordCounter2 = WordCounter;
            WordCounterTxt.text = WordCounter.ToString();
            if (WordCounter >= PlayerPrefs.GetInt(NameManager.PlayerName, 0))
                PlayerPrefs.SetInt(NameManager.PlayerName, WordCounter);



        }
    }
    
    public void Update()
    {
        
     SaveWordCount.text = PlayerPrefs.GetInt(NameManager.PlayerName, 0).ToString();
        
     LastWordCount.text = WordCounter2.ToString();
     
    }


}
