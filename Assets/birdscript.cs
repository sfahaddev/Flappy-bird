using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapstrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    private Camera mainCamera;
    public AudioSource flapeffect;
    public AudioSource deadaudio;

    private bool hasPlayedDeathAudio = false; // Flag to track if death audio has been played

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
        mainCamera = Camera.main; // Get a reference to the main camera.
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapstrength;
            flapeffect.Play();
        }

        // Check if the bird is below the camera's view.
        if (transform.position.y < mainCamera.transform.position.y - mainCamera.orthographicSize)
        {
            // Bird is below the camera's view, trigger game over.
            logic.GameOver();
            birdIsAlive = false;

            if (!hasPlayedDeathAudio)
            {
                deadaudio.Play();
                hasPlayedDeathAudio = true; // Set the flag to true after playing the audio.
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        birdIsAlive = false;

        if (!hasPlayedDeathAudio)
        {
            deadaudio.Play();
            hasPlayedDeathAudio = true; // Set the flag to true after playing the audio.
        }
    }
}
