using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandleColorSwapper : MonoBehaviour
{

    private ImageManager imageManager;

    void Start()
    {
        imageManager = GameObject.FindObjectOfType<ImageManager>();
    }

    public void HandleClick()
    {
        imageManager.activeHandle.transform.GetChild(0).gameObject.SetActive(false);
        imageManager.activeHandle = this.gameObject;
        imageManager.activeHandle.transform.GetChild(0).gameObject.SetActive(true);
    }

    public void ChangeHandleColor()
    {
        CheckSwatchTag(this.gameObject);
    }

    private void CheckSwatchTag(GameObject go)
    {
        if (go.tag == "HandleColorSwatch1")
        {

            //Debug.Log("This swatch tag is: " + go.tag);
            imageManager.activeHandle.GetComponent<Image>().sprite = imageManager.activeHandleColors[0];
        }
        else if (go.tag == "HandleColorSwatch2")
        {
            //Debug.Log("This swatch tag is: " + go.tag);
            imageManager.activeHandle.GetComponent<Image>().sprite = imageManager.activeHandleColors[1];
        }
        else if (go.tag == "HandleColorSwatch3")
        {
            imageManager.activeHandle.GetComponent<Image>().sprite = imageManager.activeHandleColors[2];
        }
        else if (go.tag == "HandleColorSwatch4")
        {
            imageManager.activeHandle.GetComponent<Image>().sprite = imageManager.activeHandleColors[3];
        }
        else if (go.tag == "HandleColorSwatch5")
        {
            imageManager.activeHandle.GetComponent<Image>().sprite = imageManager.activeHandleColors[4];
        }
        else if (go.tag == "HandleColorSwatch6")
        {
            imageManager.activeHandle.GetComponent<Image>().sprite = imageManager.activeHandleColors[5];
        }
        else if (go.tag == "HandleColorSwatch7")
        {
            imageManager.activeHandle.GetComponent<Image>().sprite = imageManager.activeHandleColors[6];
        }
        else if (go.tag == "HandleColorSwatch8")
        {
            imageManager.activeHandle.GetComponent<Image>().sprite = imageManager.activeHandleColors[7];
        }
        else
        {
            Debug.LogError("This swatch is missing a tag!");
        }
    }
}
