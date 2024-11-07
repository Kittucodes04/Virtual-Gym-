using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SoundManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] AudioSource Music;
    [SerializeField] AudioSource SFX;
    public BirdMovement status;

    public AudioClip Background, Flap, GameOver;
    void Start()
    {
        PlayBackground();
        status = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayBackground() {
        Music.clip = Background;
        Music.Play();
    }

    public void PlayFlap() {
        SFX.PlayOneShot(Flap); 
    }

    public void PlayGameOver() {
        if (status.IsBirdAlive == true) 
        {
            SFX.PlayOneShot(GameOver);
        }
        Destroy(Music);
    }
}
