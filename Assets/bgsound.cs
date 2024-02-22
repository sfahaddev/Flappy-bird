using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgsound : MonoBehaviour
{
    public AudioSource bgaudio;
    public LogicScript logic; // Reference to your game logic script

    // Start is called before the first frame update
    void Start()
    {
        bgaudio.loop = true;
        bgaudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the game is over and stop the background audio if it is.
        if (logic.IsGameOver()) // Assuming your game logic script has an "IsGameOver" method
        {
            bgaudio.Stop();
        }
    }
}
