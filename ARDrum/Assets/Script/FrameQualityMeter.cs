/*===============================================================================
Copyright(c) 2017 PTC Inc.All Rights Reserved.


Vuforia is a trademark of PTC Inc., registered in the United States and other
countries.
===============================================================================*/
using UnityEngine;
using UnityEngine.UI;

public class FrameQualityMeter : MonoBehaviour
{

    private Color ratingColor;

    [SerializeField] private string colorString;

    [SerializeField] private Image leftStarImage;
    [SerializeField] private Image middleStarImage;
    [SerializeField] private Image rightStarImage;


    private void Awake()
    {
        SetRatingColor();
    }

    public void SetQuality(Vuforia.ImageTargetBuilder.FrameQuality quality)
    {
        switch (quality)
        {
            case (Vuforia.ImageTargetBuilder.FrameQuality.FRAME_QUALITY_NONE):
                leftStarImage.color = Color.white;
                middleStarImage.color = Color.white;
                rightStarImage.color = Color.white;
                break;
            case (Vuforia.ImageTargetBuilder.FrameQuality.FRAME_QUALITY_LOW):
                leftStarImage.color = ratingColor;
                middleStarImage.color = Color.white;
                rightStarImage.color = Color.white;
                break;
            case (Vuforia.ImageTargetBuilder.FrameQuality.FRAME_QUALITY_MEDIUM):
                leftStarImage.color = ratingColor;
                middleStarImage.color = ratingColor;
                rightStarImage.color = Color.white;
                break;
            case (Vuforia.ImageTargetBuilder.FrameQuality.FRAME_QUALITY_HIGH):
                leftStarImage.color = ratingColor;
                middleStarImage.color = ratingColor;
                rightStarImage.color = ratingColor;
                break;
        }
    }

    private void SetRatingColor()
    {
        if (colorString == "")
        {
            colorString = "#fcba03";
        }

        Color color;
        ColorUtility.TryParseHtmlString(colorString, out color);

        ratingColor = color;
    }
}
