using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlay : MonoBehaviour
{
    public AudioSource mySound;
    void Update()
    {
        if (Input.anyKeyDown)
        {
            mySound.Play();
        }
    }
}
