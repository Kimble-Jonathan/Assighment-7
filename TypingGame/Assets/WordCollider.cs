using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordCollider : MonoBehaviour
{
    // Start is called before the first frame update
    public Text MissedWords;
    public int MissedWordsCounter = 0;

    private void Start()
    {
        MissedWords.text = "0";
    }
    public void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.tag == "Word")
        {
            DestroyObject(obj.gameObject);
            MissedWordsCounter++;
            MissedWords.text = MissedWordsCounter.ToString();
            

        }
    }
}
