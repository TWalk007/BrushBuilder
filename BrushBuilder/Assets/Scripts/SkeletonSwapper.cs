using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkeletonSwapper : MonoBehaviour
{
    private ImageManager imageManager;

    void Start()
    {
        imageManager = GameObject.FindObjectOfType<ImageManager>();
    }

    // Update is called once per frame
    public void ChangeSkeleton()
    {
        CheckSwatch(this.gameObject.GetComponent<Image>().sprite);
    }

    private void CheckSwatch(Sprite sprite)
    {
        if (sprite.name == "UI_Family_Wht_Swatch-A")
        {
            imageManager.family = ImageManager.Family.Whitening1;
        }
        else if (sprite.name == "UI_Family_Wht_Swatch-B")
        {
            imageManager.family = ImageManager.Family.Whitening2;
        }
        else if (sprite.name == "UI_Family_Wht_Swatch-C")
        {
            imageManager.family = ImageManager.Family.Whitening3;
        }
        else if (sprite.name == "UI_Family_GC_Swatch-A")
        {
            imageManager.family = ImageManager.Family.GumCare1;
        }
        else if (sprite.name == "UI_Family_GC_Swatch-B")
        {
            imageManager.family = ImageManager.Family.GumCare2;
        }
        else if (sprite.name == "UI_Family_GC_Swatch-C")
        {
            imageManager.family = ImageManager.Family.GumCare3;
        }
        else if (sprite.name == "UI_Family_AC_Swatch-A")
        {
            imageManager.family = ImageManager.Family.AdvancedCleaning1;
        }
        else if (sprite.name == "UI_Family_AC_Swatch-B")
        {
            imageManager.family = ImageManager.Family.AdvancedCleaning2;
        }
        else if (sprite.name == "UI_Family_AC_Swatch-C")
        {
            imageManager.family = ImageManager.Family.AdvancedCleaning3;
        }
    }
}
