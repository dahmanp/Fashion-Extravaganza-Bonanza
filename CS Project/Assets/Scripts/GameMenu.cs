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

    public string player;
    public bool maxHatReached = false;
    public bool maxHairReached = false;
    public bool maxShoesReached = false;
    public bool maxPantsReached = false;
    public bool maxGlassesReached = false;
    public bool maxPetsReached = false;
    public bool maxbgReached = false;
    public bool maxShirtsReached = false;

    public GameObject planeBG;

    public int minVal = 0;

    public GameObject[] prettyGirl;
    public GameObject[] gigaChad;
    public GameObject[] funny;

    private int currHatOption;
    private int currHairOption;
    private int currShoesOption;
    private int currPantsOption;
    private int currGlassesOption;
    private int currPetsOption;
    private int currbgOption;
    private int currShirtsOption;


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
        foreach (GameObject prettyGirl in prettyGirl)
        {
            prettyGirl.SetActive(true);
        }
        foreach (GameObject gigaChad in gigaChad)
        {
            gigaChad.SetActive(false);
        }
        foreach (GameObject funny in funny)
        {
            funny.SetActive(false);
        }
    }

    public void GigaChad()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = festiveBling;
        audio.Play();
        foreach (GameObject gigaChad in gigaChad)
        {
            gigaChad.SetActive(true);
        }
        foreach (GameObject prettyGirl in prettyGirl)
        {
            prettyGirl.SetActive(false);
        }
        foreach (GameObject funny in funny)
        {
            funny.SetActive(false);
        }
    }

    public void Funny()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = festiveBling;
        audio.Play();
        foreach (GameObject funny in funny)
        {
            funny.SetActive(true);
        }
        foreach (GameObject gigaChad in gigaChad)
        {
            gigaChad.SetActive(false);
        }
        foreach (GameObject prettyGirl in prettyGirl)
        {
            prettyGirl.SetActive(false);
        }
    }

    //CYCLING BGS--------------------------------------------------------------------
    public void BGSelectButton()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = festiveBling;
        audio.Play();
        if (maxbgReached == true)
        {
            currbgOption = 0;
            maxbgReached = false;
        }

        if (currbgOption < 6)
        {
            planeBG.gameObject.GetComponent<MeshRenderer>().material = bg[currbgOption];
        }
        currbgOption++;

        if (currbgOption == 6)
        {
            planeBG.gameObject.GetComponent<MeshRenderer>().material = bg[6];
            maxbgReached = true;
        }
    }

    //CYCLING CLOTHES--------------------------------------------------------------------
    public void HatRightButton()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = festiveBling;
        audio.Play();
        if (maxHatReached == true)
        {
            hats[9].SetActive(false);
            currHatOption = 0;
            maxHatReached = false;
        }

        if(currHatOption < 9)
        {
            if(currHatOption > 0)
            {
                hats[currHatOption - 1].SetActive(false);
            }
            hats[currHatOption].SetActive(true);
        }
        currHatOption++;

        if(currHatOption == 9)
        {
            hats[9 - 1].SetActive(false);
            hats[9].SetActive(true);
            maxHatReached = true;
        }
    }

    public void HairRightButton()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = festiveBling;
        audio.Play();
        if (maxHairReached == true)
        {
            hair[4].SetActive(false);
            currHairOption = 0;
            maxHairReached = false;
        }

        if (currHairOption < 4)
        {
            if (currHairOption > 0)
            {
                hair[currHairOption - 1].SetActive(false);
            }
            hair[currHairOption].SetActive(true);
        }
        currHairOption++;
        

        if (currHairOption == 4)
        {
            hair[4 - 1].SetActive(false);
            hair[4].SetActive(true);
            maxHairReached = true;
        }
    }

    public void GlassesRightButton()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = festiveBling;
        audio.Play();
        if (maxGlassesReached == true)
        {
            glasses[4].SetActive(false);
            currGlassesOption = 0;
            maxGlassesReached = false;
        }

        if (currGlassesOption < 4)
        {
            if (currGlassesOption > 0)
            {
                glasses[currGlassesOption - 1].SetActive(false);
            }
            glasses[currGlassesOption].SetActive(true);
        }
        currGlassesOption++;

        if (currGlassesOption == 4)
        {
            glasses[4 - 1].SetActive(false);
            glasses[4].SetActive(true);
            maxGlassesReached = true;
        }
    }

    public void ShirtsRightButton()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = festiveBling;
        audio.Play();
        if (maxShirtsReached == true)
        {
            shirts[4].SetActive(false);
            currShirtsOption = 0;
            maxShirtsReached = false;
        }

        if (currShirtsOption < 4)
        {
            if (currShirtsOption > 0)
            {
                shirts[currShirtsOption - 1].SetActive(false);
            }
            shirts[currShirtsOption].SetActive(true);
        }
        currShirtsOption++;

        if (currShirtsOption == 4)
        {
            shirts[4 - 1].SetActive(false);
            shirts[4].SetActive(true);
            maxShirtsReached = true;
        }
    }
    
    public void PantsRightButton()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = festiveBling;
        audio.Play();
        if (maxPantsReached == true)
        {
            pants[4].SetActive(false);
            currPantsOption = 0;
            maxPantsReached = false;
        }

        if (currPantsOption < 4)
        {
            if (currPantsOption > 0)
            {
                pants[currPantsOption - 1].SetActive(false);
            }
            pants[currPantsOption].SetActive(true);
        }
        currPantsOption++;

        if (currPantsOption == 4)
        {
            pants[4 - 1].SetActive(false);
            pants[4].SetActive(true);
            maxPantsReached = true;
        }
    }

    public void ShoesRightButton()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = festiveBling;
        audio.Play();
        if (maxShoesReached == true)
        {
            shoes[3].SetActive(false);
            currShoesOption = 0;
            maxShoesReached = false;
        }

        if (currShoesOption < 3)
        {
            if (currShoesOption > 0)
            {
                shoes[currShoesOption - 1].SetActive(false);
            }
            shoes[currShoesOption].SetActive(true);
        }
        currShoesOption++;

        if (currShoesOption == 3)
        {
            shoes[3 - 1].SetActive(false);
            shoes[3].SetActive(true);
            maxShoesReached = true;
        }
    }

    public void PetsRightButton()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = festiveBling;
        audio.Play();
        if (maxPetsReached == true)
        {
            pets[8].SetActive(false);
            currPetsOption = 0;
            maxPetsReached = false;
        }

        if (currPetsOption < 8)
        {
            if (currPetsOption > 0)
            {
                pets[currPetsOption - 1].SetActive(false);
            }
            pets[currPetsOption].SetActive(true);
        }
        currPetsOption++;

        if (currPetsOption == 8)
        {
            pets[8 - 1].SetActive(false);
            pets[8].SetActive(true);
            maxPetsReached = true;
        }
    }
}
