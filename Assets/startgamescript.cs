using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startgamescript : MonoBehaviour
{
    public AudioSource bgaudio;
    public void startgame()
    {
        bgaudio.Play();


        SceneManager.LoadSceneAsync(1);
    }


}
