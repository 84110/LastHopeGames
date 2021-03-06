﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class fadeout : MonoBehaviour
{
    float speed = 0;
    float alpha = 0;
    float red, green, blue;

    public void toFadeout()
    {
        red = GetComponent<Image>().color.r;
        green = GetComponent<Image>().color.g;
        blue = GetComponent<Image>().color.b;
        speed = 0.01f;

        GetComponent<Image>().color = new Color(red, green, blue, alpha);
        alpha += speed;
    }
    
}
