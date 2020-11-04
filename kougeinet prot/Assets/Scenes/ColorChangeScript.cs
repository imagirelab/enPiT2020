using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChangeScript : MonoBehaviour
{
    public Image colorImage;
    public Button whiteButton;
    public Button redButton;
    public Button blueButton;
    public Button greenButton;
    public Button yellowButton;
    public Button blackButton;
    public Button purpleButton;
    public Button cyanButton;
    public Button orangeButton;
    public Button dGreenButton;

    public static Color nowColor;
    public static int colorNum;

    // Start is called before the first frame update
    void Start()
    {
        colorImage.color = SaveScript.whiteC;
        whiteButton.image.color = SaveScript.whiteC;
        redButton.image.color = SaveScript.redC;
        blueButton.image.color = SaveScript.blueC;
        greenButton.image.color = SaveScript.greenC;
        yellowButton.image.color = SaveScript.yellowC;
        blackButton.image.color = SaveScript.blackC;
        purpleButton.image.color = SaveScript.purpleC;
        cyanButton.image.color = SaveScript.cyanC;
        orangeButton.image.color = SaveScript.orangeC;
        dGreenButton.image.color = SaveScript.dGreenC;
        nowColor = SaveScript.whiteC;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WhiteChangeImage()
    {
        colorImage.color = SaveScript.whiteC;
        nowColor = colorImage.color;
        colorNum = 0;
    }
    public void RedChangeImage()
    {
        colorImage.color = SaveScript.redC;
        nowColor = colorImage.color;
        colorNum = 1;
    }
    public void BlueChangeImage()
    {
        colorImage.color = SaveScript.blueC;
        nowColor = colorImage.color;
        colorNum = 2;
    }
    public void GreenChangeImage()
    {
        colorImage.color = SaveScript.greenC;
        nowColor = colorImage.color;
        colorNum = 3;
    }
    public void YellowChangeImage()
    {
        colorImage.color = SaveScript.yellowC;
        nowColor = colorImage.color;
        colorNum = 4;
    }
    public void BlackChangeImage()
    {
        colorImage.color = SaveScript.blackC;
        nowColor = colorImage.color;
        colorNum = 5;
    }
    public void PurpleChangeImage()
    {
        colorImage.color = SaveScript.purpleC;
        nowColor = colorImage.color;
        colorNum = 6;
    }
    public void CyanChangeImage()
    {
        colorImage.color = SaveScript.cyanC;
        nowColor = colorImage.color;
        colorNum = 7;
    }
    public void OrangeChangeImage()
    {
        colorImage.color = SaveScript.orangeC;
        nowColor = colorImage.color;
        colorNum = 8;
    }
    public void DGreenChangeImage()
    {
        colorImage.color = SaveScript.dGreenC;
        nowColor = colorImage.color;
        colorNum = 9;
    }
}
