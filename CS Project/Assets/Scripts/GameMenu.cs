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

    public AudioClip festiveBling;
    public TextMeshProUGUI playerText;
    public GameObject screenshotText;
    public TMP_InputField field;
    public int currOption;
    public string player;

    private GameObject[] prettyGirl;
    private GameObject[] gigaChad;
    private GameObject[] funny;


    //SCREEN MANAGEMENT--------------------------------------------------------------------
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

    //TEXT-------------------------------------------------------------------------------
    /*public void SetPlayerName()
    {
        field.text = field.text.ToString();
        

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
    }*/

    public void SetName()
    {
        player = field.text;
    }

    public void SetWinText()
    {
        //SetName();
        playerText.text = "You look FABULOUS, " + player + "!!!";
    }

    //CLOTHING PRESETS--------------------------------------------------------------------
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

    //CLOTHING CHOICE--------------------------------------------------------------------
    //HATS

    /* Idea for button code
    remove left button 

    RightHatButton(){
        //int i = 0; //start of options
        //bool maxReached = false;
        
        //9 is max hat array
        if(maxreached == true)
        {
            hat[9].SetActive(false);
            i = 0;
        }
        
        //always check if max option reached
        
        if(i<9){

            if(i > 0){
                hat[R - 1].SetActive(false);
                // if i is already at lowest value skip setting the one before it false
            }
            hat[i].SetActive(true);
            i++;
        }
        //check max value so that we are able to display 9 and also make sure it knows the limit was reached
        if(i==9)
        {
            hat[8].SetActive(false);
            hat[9].SetActive(true);
            maxReached = true;
            
        }
    //if hat is not reached its max array num then set cur option active and increase i and disable the one before;
    //if i has reached its max value in array (9 or above) set i back to 0 and set that one active and disable one before;
    //circles through options
    //maybe replace 9 with a variable called maxOptions so we can call this function for multiple clothing options.
    }
    
    public void HatLeftButton()
    {
        LeftButton(hats, 9);
    }
    public void HatRightButton()
    {
        RightButton(hats, 9);
    }

    //HAIR
    public void HairLeftButton()
    {
        LeftButton(hair, 4);
    }
    public void HairRightButton()
    {
        RightButton(hair, 4);
    }

    //GLASSES
    public void GlassesLeftButton()
    {
        LeftButton(glasses, 4);
    }
    public void GlassesRightButton()
    {
        RightButton(glasses, 4);
    }

    //SHIRTS
    public void ShirtsLeftButton()
    {
        LeftButton(shirts, 4);
    }
    public void ShirtsRightButton()
    {
        RightButton(shirts, 4);
    }

    //PANTS
    public void PantsLeftButton()
    {
        LeftButton(pants, 4);
    }
    public void PantsRightButton()
    {
        RightButton(pants, 4);
    }

    //SHOES
    public void ShoesLeftButton()
    {
        LeftButton(shoes, 3);
    }
    public void ShoesRightButton()
    {
        RightButton(shoes, 3);
    }

    //PETS
    public void PetsLeftButton()
    {
        LeftButton(pets, 8);
    }
    public void PetsRightButton()
    {
        RightButton(pets, 8);
    }

    //CYCLING CLOTHES--------------------------------------------------------------------
    public void LeftButton(GameObject[] array, int maxval)
    {
        GetComponent<AudioSource>().clip = festiveBling;
        GetComponent<AudioSource>().Play();
        if (currOption == maxval)
        {
            array[0].SetActive(false);
        }
        else
        {
            array[currOption + 1].SetActive(false);
        }
        array[currOption].SetActive(true);
        currOption--;
    }

    public void RightButton(GameObject[] array, int maxval)
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = festiveBling;
        audio.Play();
        if (currOption == 0)
        {
            array[maxval].SetActive(false);
        }
        else
        {
            array[currOption - 1].SetActive(false);
        }
        array[currOption].SetActive(true);
        currOption++;
    }
}
