using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundSwapper : MonoBehaviour
{
    public List<Sprite> backgroundImageList; //All backgrounds can be placed in here
    public Image image;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        //press a number to change to the next background
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
             image.sprite = backgroundImageList[0];
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            image.sprite = backgroundImageList[1];
        }
    }
}
