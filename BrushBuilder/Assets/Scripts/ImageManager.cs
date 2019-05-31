using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageManager : MonoBehaviour
{    
    public enum Family
    {
        Whitening1,
        Whitening2,
        Whitening3,
        GumCare1,
        GumCare2,
        GumCare3,
        AdvancedCleaning1,
        AdvancedCleaning2,
        AdvancedCleaning3
      };

    [Space(10)]
    public Family family;

    #region Public GameObjects
    public GameObject wht1;
    public GameObject wht2;
    public GameObject wht3;
    public GameObject gc1;
    public GameObject gc2;
    public GameObject gc3;
    public GameObject ac1;
    public GameObject ac2;
    public GameObject ac3;

    [Space(10)]
    [Header("SKELETON SWATCHES")]
    [Header("=============================================================")]
    public GameObject wht1SkeletonSwatchHL;
    public GameObject wht2SkeletonSwatchHL;
    public GameObject wht3SkeletonSwatchHL;
    public GameObject gc1SkeletonSwatchHL;
    public GameObject gc2SkeletonSwatchHL;
    public GameObject gc3SkeletonSwatchHL;
    public GameObject ac1SkeletonSwatchHL;
    public GameObject ac2SkeletonSwatchHL;
    public GameObject ac3SkeletonSwatchHL;


    [Space(10)]
    [Header("FAMILY HIGHLIGHTS")]
    [Header("=============================================================")]
    public Sprite whiteningFamily;
    public Sprite whiteningFamilyHL;
    public Sprite gumCareFamily;
    public Sprite gumCareFamilyHL;
    public Sprite advCleaningFamily;
    public Sprite advCleaningFamilyHL;
    [Space(10)]
    [Header("FAMILY GAMEOBJECTS")]
    [Header("_____________________________________________________________")]
    public GameObject whtFamily;
    public GameObject gcFamily;
    public GameObject acFamily;
    #endregion


    private GameObject currentPanel;
    private GameObject currentHL;

    public GameObject currentBristleSwatchHL;

    //TODO Place all of the scripts for each family here.
    private FamilyData_Whitening1 famDataWht1;
    private FamilyData_Whitening2 famDataWht2;


    // This is a placeholder variable to put the correct family colors to grab into these slots.
    [HideInInspector]
    public GameObject[] brushDisplayPanels;
    [HideInInspector]
    public GameObject[] brushHeadDisplayPanels;
    [HideInInspector]
    public Sprite[] activeHandleColors;
    [HideInInspector]
    public Sprite[] activeBristleColors;
    [HideInInspector]
    public Sprite[] activeLargeBristleHeads;

    public GameObject activeHandle;
    public GameObject activeHandleHead;

    private void Start()
    {
        family = Family.Whitening1;
        currentPanel = wht1;
        currentHL = wht1SkeletonSwatchHL;

        famDataWht1 = this.gameObject.GetComponent<FamilyData_Whitening1>();
        famDataWht2 = this.gameObject.GetComponent<FamilyData_Whitening2>();
    }

    private void Update()
    {


        #region enum Family Switch
        if (family == Family.Whitening1)
        {
            currentPanel.SetActive(false);
            currentPanel = wht1;
            currentPanel.SetActive(true);

            currentHL.SetActive(false);
            currentHL = wht1SkeletonSwatchHL;
            currentHL.SetActive(true);

            whtFamily.GetComponent<Image>().sprite = whiteningFamilyHL;
            gcFamily.GetComponent<Image>().sprite = gumCareFamily;
            acFamily.GetComponent<Image>().sprite = advCleaningFamily;

            brushDisplayPanels = famDataWht1.brushDisplayPanels;
            brushHeadDisplayPanels = famDataWht1.brushHeadDisplayPanels;
            activeHandleColors = famDataWht1.handleColors;
            activeBristleColors = famDataWht1.handleHeadColors;
            activeLargeBristleHeads = famDataWht1.largeBristleHeadSprites;
        }
        else if (family == Family.Whitening2)
        {
            currentPanel.SetActive(false);
            currentPanel = wht2;
            currentPanel.SetActive(true);

            currentHL.SetActive(false);
            currentHL = wht2SkeletonSwatchHL;
            currentHL.SetActive(true);

            whtFamily.GetComponent<Image>().sprite = whiteningFamilyHL;
            gcFamily.GetComponent<Image>().sprite = gumCareFamily;
            acFamily.GetComponent<Image>().sprite = advCleaningFamily;

            brushDisplayPanels = famDataWht2.brushDisplayPanels;
            brushHeadDisplayPanels = famDataWht2.brushHeadDisplayPanels;
            activeHandleColors = famDataWht2.handleColors;
            activeBristleColors = famDataWht2.handleHeadColors;
            activeLargeBristleHeads = famDataWht2.largeBristleHeadSprites;
        }
        else if (family == Family.Whitening3)
        {
            currentPanel.SetActive(false);
            currentPanel = wht3;
            currentPanel.SetActive(true);

            whtFamily.GetComponent<Image>().sprite = whiteningFamilyHL;
            gcFamily.GetComponent<Image>().sprite = gumCareFamily;
            acFamily.GetComponent<Image>().sprite = advCleaningFamily;

            currentHL.SetActive(false);
            currentHL = wht3SkeletonSwatchHL;
            currentHL.SetActive(true);
        }
        else if (family == Family.GumCare1)
        {
            currentPanel.SetActive(false);
            currentPanel = gc1;
            currentPanel.SetActive(true);

            whtFamily.GetComponent<Image>().sprite = whiteningFamily;
            gcFamily.GetComponent<Image>().sprite = gumCareFamilyHL;
            acFamily.GetComponent<Image>().sprite = advCleaningFamily;

            currentHL.SetActive(false);
            currentHL = gc1SkeletonSwatchHL;
            currentHL.SetActive(true);
        }
        else if (family == Family.GumCare2)
        {
            currentPanel.SetActive(false);
            currentPanel = gc2;
            currentPanel.SetActive(true);

            whtFamily.GetComponent<Image>().sprite = whiteningFamily;
            gcFamily.GetComponent<Image>().sprite = gumCareFamilyHL;
            acFamily.GetComponent<Image>().sprite = advCleaningFamily;

            currentHL.SetActive(false);
            currentHL = gc2SkeletonSwatchHL;
            currentHL.SetActive(true);
        }
        else if (family == Family.GumCare3)
        {
            currentPanel.SetActive(false);
            currentPanel = gc3;
            currentPanel.SetActive(true);

            whtFamily.GetComponent<Image>().sprite = whiteningFamily;
            gcFamily.GetComponent<Image>().sprite = gumCareFamilyHL;
            acFamily.GetComponent<Image>().sprite = advCleaningFamily;

            currentHL.SetActive(false);
            currentHL = gc3SkeletonSwatchHL;
            currentHL.SetActive(true);
        }
        else if (family == Family.AdvancedCleaning1)
        {
            currentPanel.SetActive(false);
            currentPanel = ac1;
            currentPanel.SetActive(true);

            whtFamily.GetComponent<Image>().sprite = whiteningFamily;
            gcFamily.GetComponent<Image>().sprite = gumCareFamily;
            acFamily.GetComponent<Image>().sprite = advCleaningFamilyHL;

            currentHL.SetActive(false);
            currentHL = ac1SkeletonSwatchHL;
            currentHL.SetActive(true);
        }
        else if (family == Family.AdvancedCleaning2)
        {
            currentPanel.SetActive(false);
            currentPanel = ac2;
            currentPanel.SetActive(true);

            whtFamily.GetComponent<Image>().sprite = whiteningFamily;
            gcFamily.GetComponent<Image>().sprite = gumCareFamily;
            acFamily.GetComponent<Image>().sprite = advCleaningFamilyHL;

            currentHL.SetActive(false);
            currentHL = ac2SkeletonSwatchHL;
            currentHL.SetActive(true);
        }
        else if (family == Family.AdvancedCleaning3)
        {
            currentPanel.SetActive(false);
            currentPanel = ac3;
            currentPanel.SetActive(true);

            whtFamily.GetComponent<Image>().sprite = whiteningFamily;
            gcFamily.GetComponent<Image>().sprite = gumCareFamily;
            acFamily.GetComponent<Image>().sprite = advCleaningFamilyHL;

            currentHL.SetActive(false);
            currentHL = ac3SkeletonSwatchHL;
            currentHL.SetActive(true);
        }
        else
        {
            Debug.LogError("No Family is selected!");
        }
        #endregion
    }
}
