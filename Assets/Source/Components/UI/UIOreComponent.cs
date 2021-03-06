﻿using Assets.Source.Data;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIOreComponent : MonoBehaviour
{
    public Image image;
    public Text countText;

    private Ore ore;
    public Ore Ore
    {
        get
        {
            return ore;
        }

        set
        {
            ore = value;
            image.sprite = ore.sprite;
        }
    }

    private int count;
    public int Count
    {
        get
        {
            return count;
        }

        set
        {
            count = value;
            countText.text = count.ToString();
        }
    }
}
