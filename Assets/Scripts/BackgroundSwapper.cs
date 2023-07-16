using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundSwapper : MonoBehaviour
{
    public List<Sprite> backgroundImageList; //All backgrounds can be placed in here
    public Image image;
    public float fadeDuration = 0.2f;
    public int backgroundImageValue;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        
        if (Input.GetKeyDown(KeyCode.Alpha1) && image.sprite != backgroundImageList[0]) // set the value in "backgroundImageList[?] to the position of the image you're switching to
        {
            backgroundImageValue = 0; // change this to the position of the image you're switching to in the list
            StartCoroutine(FadeToBlack()); // fades background to black, changes the image, then fades back
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) && image.sprite != backgroundImageList[1]) // set the value in "backgroundImageList[?] to the position of the image you're switching to
        {
            backgroundImageValue = 1; // change this to the position of the image you're switching to in the list
            StartCoroutine(FadeToBlack()); // fades background to black, changes the image, then fades back
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) && image.sprite != backgroundImageList[2]) // set the value in "backgroundImageList[?] to the position of the image you're switching to
        {
            backgroundImageValue = 2; // change this to the position of the image you're switching to in the list
            StartCoroutine(FadeToBlack()); // fades background to black, changes the image, then fades back
        }

        */
    }


    public void CafeteriaMidday() // called by the dialogue
    {
        backgroundImageValue = 0; // change this to the position of the image you're switching to in the list
        StartCoroutine(FadeToBlack()); // fades background to black, changes the image, then fades back
    }
    public void ClassMidday() // called by the dialogue
    {
        backgroundImageValue = 1; // change this to the position of the image you're switching to in the list
        StartCoroutine(FadeToBlack()); // fades background to black, changes the image, then fades back
    }
    public void OutsideSchoolMidday() // called by the dialogue
    {
        backgroundImageValue = 2; // change this to the position of the image you're switching to in the list
        StartCoroutine(FadeToBlack()); // fades background to black, changes the image, then fades back
    }
    public void BedroomNight() // called by the dialogue
    {
        backgroundImageValue = 3; // change this to the position of the image you're switching to in the list
        StartCoroutine(FadeToBlack()); // fades background to black, changes the image, then fades back
    }
    public void KitchenMidday() // called by the dialogue
    {
        backgroundImageValue = 4; // change this to the position of the image you're switching to in the list
        StartCoroutine(FadeToBlack()); // fades background to black, changes the image, then fades back
    }
    public void LoungeNight() // called by the dialogue
    {
        backgroundImageValue = 5; // change this to the position of the image you're switching to in the list
        StartCoroutine(FadeToBlack()); // fades background to black, changes the image, then fades back
    }
    public void TableMidday() // called by the dialogue
    {
        backgroundImageValue = 6; // change this to the position of the image you're switching to in the list
        StartCoroutine(FadeToBlack()); // fades background to black, changes the image, then fades back
    }

    public void VendingMachine() // called by the dialogue
    {
        backgroundImageValue = 7; // change this to the position of the image you're switching to in the list
        StartCoroutine(FadeToBlack()); // fades background to black, changes the image, then fades back
    }
    public void CookBook() // called by the dialogue
    {
        backgroundImageValue = 8; // change this to the position of the image you're switching to in the list
        StartCoroutine(FadeToBlack()); // fades background to black, changes the image, then fades back
    }
    public void Healthy1Salad() // called by the dialogue
    {
        backgroundImageValue = 9; // change this to the position of the image you're switching to in the list
        StartCoroutine(FadeToBlack()); // fades background to black, changes the image, then fades back
    }
    public void Healthy2Fish() // called by the dialogue
    {
        backgroundImageValue = 10; // change this to the position of the image you're switching to in the list
        StartCoroutine(FadeToBlack()); // fades background to black, changes the image, then fades back
    }
    public void Healthy3PumpkinSoup() // called by the dialogue
    {
        backgroundImageValue = 11; // change this to the position of the image you're switching to in the list
        StartCoroutine(FadeToBlack()); // fades background to black, changes the image, then fades back
    }
    public void Mid1Spaghetti() // called by the dialogue
    {
        backgroundImageValue = 12; // change this to the position of the image you're switching to in the list
        StartCoroutine(FadeToBlack()); // fades background to black, changes the image, then fades back
    }
    public void Mid2RoastChicken() // called by the dialogue
    {
        backgroundImageValue = 13; // change this to the position of the image you're switching to in the list
        StartCoroutine(FadeToBlack()); // fades background to black, changes the image, then fades back
    }
    public void Mid3SteakMeal() // called by the dialogue
    {
        backgroundImageValue = 14; // change this to the position of the image you're switching to in the list
        StartCoroutine(FadeToBlack()); // fades background to black, changes the image, then fades back
    }
    public void Unhealthy1Pizza() // called by the dialogue
    {
        backgroundImageValue = 15; // change this to the position of the image you're switching to in the list
        StartCoroutine(FadeToBlack()); // fades background to black, changes the image, then fades back
    }
    public void Unhealthy2FastFood() // called by the dialogue
    {
        backgroundImageValue = 16; // change this to the position of the image you're switching to in the list
        StartCoroutine(FadeToBlack()); // fades background to black, changes the image, then fades back
    }
    public void Unhealthy3Pancakes() // called by the dialogue
    {
        backgroundImageValue = 17; // change this to the position of the image you're switching to in the list
        StartCoroutine(FadeToBlack()); // fades background to black, changes the image, then fades back
    }
    public void KitchenNight() // called by the dialogue
    {
        backgroundImageValue = 18; // change this to the position of the image you're switching to in the list
        StartCoroutine(FadeToBlack()); // fades background to black, changes the image, then fades back
    }

    public void YouWin() // called by the dialogue
    {
        backgroundImageValue = 19; // change this to the position of the image you're switching to in the list
        StartCoroutine(FadeToBlack()); // fades background to black, changes the image, then fades back
    }

    public void YouLose() // called by the dialogue
    {
        backgroundImageValue = 20; // change this to the position of the image you're switching to in the list
        StartCoroutine(FadeToBlack()); // fades background to black, changes the image, then fades back
    }


    IEnumerator FadeToBlack()
    {
        // fades the background to black
        Color originalColor = image.color;
        float timer = 0.0f;

        while (timer < fadeDuration)
        {
            timer += Time.deltaTime;
            float ratio = timer / fadeDuration;
            image.color = Color.Lerp(originalColor, Color.black, ratio);
            yield return null;
        }

        image.color = Color.black; // Ensure final color is black
        image.sprite = backgroundImageList[backgroundImageValue]; // changes the background image
        StartCoroutine(FadeBack()); // fades back to the new image
    }

    IEnumerator FadeBack()
    {
        Color originalColor = image.color;
        float timer = 0.0f;

        while (timer < fadeDuration)
        {
            timer += Time.deltaTime;
            float ratio = timer / fadeDuration;
            image.color = Color.Lerp(originalColor, Color.white, ratio);
            yield return null;
        }

        image.color = Color.white;
    }


}
