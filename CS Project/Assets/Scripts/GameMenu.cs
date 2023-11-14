using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    public GameObject changeBG;
    public GameObject nameHomie;
    public GameObject dressUp;
    public GameObject showcase;

    public GameObject[] shirts = new GameObject[3];
    public GameObject[] pants = new GameObject[4];
    public GameObject[] hair = new GameObject[3];
    public GameObject[] shoes = new GameObject[3];
    public GameObject[] hats = new GameObject[3];
    public GameObject[] glasses = new GameObject[3];
    public GameObject[] pets = new GameObject[3];
    public Material[] bg = new Material[6];

    private GameObject[] prettyGirl;
    private GameObject[] gigaChad;
    private GameObject[] funny;

    public AudioClip festiveBling;
    public TextMeshProUGUI playerText;
    public GameObject screenshotText;
    public Text playerName;
    public InputField field;
    public int CurrOption = 9;


    //create arrays for each category

    void SetScreen(GameObject screen)
    {
        // disable all other screens
        changeBG.SetActive(false);
        nameHomie.SetActive(false);
        dressUp.SetActive(false);
        showcase.SetActive(false);
        // activate the requested screen
        screen.SetActive(true);
    }

    public void BackToMainMenu()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = festiveBling;
        audio.Play();
        SceneManager.LoadScene("Menu");
    }

    public void ToBGChoice()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = festiveBling;
        audio.Play();
        SetScreen(changeBG);
    }

    public void ToNaming()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = festiveBling;
        audio.Play();
        SetScreen(nameHomie);
    }

    public void ToMenu()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = festiveBling;
        audio.Play();
        SetScreen(dressUp);
    }
    
    public void ToShowcase()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = festiveBling;
        audio.Play();
        SetScreen(showcase);
    }

    public void ToCredits()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = festiveBling;
        audio.Play();
        SceneManager.LoadScene("Credits");
    }

    public void TakeScreenshotButton()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = festiveBling;
        audio.Play();
        ScreenCapture.CaptureScreenshot("Slay.png");
        
    }

    public void SetPlayerName()
    {
        //field.text = field.text.ToString();
        //field.text = GameNewSave.PlayerName;

        //playerName.text = PlayerPrefs.GetString("homieName");
        //playerName.text = field.text;
        //PlayerPrefs.SetString("homieName", playerName.text);
        //PlayerPrefs.Save();
    }

    public void UpdateText()
    {
        screenshotText.SetActive(true);
    }

    public void SetPlayerText()
    {
        //playerText.text = "You look FABULOUS, " + PlayerName + "!!!";
    }

    //Homie Clothes Presets
    public void PrettyGirl()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = festiveBling;
        audio.Play();
        prettyGirl = GameObject.FindGameObjectsWithTag("PrettyGirl");
        foreach (GameObject prettyGirl in prettyGirl)
        {
            prettyGirl.SetActive(true);
        }
    }

    public void GigaChad()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = festiveBling;
        audio.Play();
        gigaChad = GameObject.FindGameObjectsWithTag("GigaChad");
        foreach (GameObject gigaChad in gigaChad)
        {
            gigaChad.SetActive(true);
        }
    }

    public void Funny()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = festiveBling;
        audio.Play();
        funny = GameObject.FindGameObjectsWithTag("Funny");
        foreach (GameObject funny in funny)
        {
            funny.SetActive(true);
        }
    }
    //Cycling clothes
    //HAT
    public void HatLeftButton()
    {
        //check negative if then set to 9?
        if (CurrOption == 9 )
        {
            hats[0].SetActive(false);

        }
        else
        {
            hats[CurrOption + 1].SetActive(false);
        }
            hats[CurrOption].SetActive(true);
            CurrOption--;
    }

}
