using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageSwapper : MonoBehaviour
{
    private Image startImage;

    public void ButtonPress()
    {
        startImage = this.gameObject.GetComponent<Image>();

        //if (startImage.sprite != brushImages[0])
        //{
        //    print("you can change me.");
        //}
    }
       

}
