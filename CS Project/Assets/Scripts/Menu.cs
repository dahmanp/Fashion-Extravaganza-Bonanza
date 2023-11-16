using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Button playGame;
    public Button showCredits;
    public Button showMenu;
    public AudioClip festiveBling;

    public void OnCreditsButton()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = festiveBling;
        audio.Play();
        SceneManager.LoadScene("Credits");
    }

    public void OnMenuButton()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = festiveBling;
        audio.Play();
        SceneManager.LoadScene("Menu");
    }

    public void PlayGameButton()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = festiveBling;
        audio.Play();
        SceneManager.LoadScene("Game");
    }
}
