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
    public Button yellowButton;

    public static Color nowColor;
    public static int colorNum;

    // Start is called before the first frame update
    void Start()
    {
        colorImage.color = Color.white;
        whiteButton.image.color = Color.white;
        redButton.image.color = Color.red;
        blueButton.image.color = Color.blue;
        yellowButton.image.color = Color.yellow;
        nowColor = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WhiteChangeImage()
    {
        colorImage.color = Color.white;
        nowColor = colorImage.color;
        colorNum = 0;
    }
    public void RedChangeImage()
    {
        colorImage.color = Color.red;
        nowColor = colorImage.color;
        colorNum = 1;
    }
    public void BlueChangeImage()
    {
        colorImage.color = Color.blue;
        nowColor = colorImage.color;
        colorNum = 2;
    }
    public void YellowChangeImage()
    {
        colorImage.color = Color.yellow;
        nowColor = colorImage.color;
        colorNum = 3;
    }
}
