using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    public AudioSource sfx;

    void playMusic() {
        sfx.Play();
    }
}
