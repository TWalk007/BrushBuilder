using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageManager : MonoBehaviour
{
    [Header("Complete Brush Images")]
    public Sprite[] brushImages = new Sprite[4];

    public enum Family
    {
        Whitening1,
        Whitening2,
        GumCare1,
        GumCare2,
        GumCare3,
        AdvancedCleaning1,
        AdvancedCleaning2,
        MultiBenefit1,
        MultiBenefit2,
        MultiBenefit3
      };

    [Space(10)]
    public Family family;

    private void Start()
    {
        family = Family.Whitening1;
    }

    private void Update()
    {
        if (family == Family.Whitening1)
        {

        }
        else if (family == Family.Whitening2)
        {

        }
        else if (family == Family.GumCare1)
        {

        }
        else if (family == Family.GumCare2)
        {

        }
        else if (family == Family.GumCare3)
        {

        }
        else if (family == Family.AdvancedCleaning1)
        {

        }
        else if (family == Family.AdvancedCleaning2)
        {

        }
        else if (family == Family.MultiBenefit1)
        {

        }
        else if (family == Family.MultiBenefit2)
        {

        }
        else if (family == Family.MultiBenefit3)
        {

        }
    }
}
