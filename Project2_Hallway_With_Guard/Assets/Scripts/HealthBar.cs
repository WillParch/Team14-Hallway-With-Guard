using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    public static HealthBar instance { get; private set; }
    public Image hpBar;
    float MaxHP;

    void Awake()
    {
        instance = this;
    }
    void Start()
    {
       MaxHP = hpBar.rectTransform.rect.width;
    }
    
    public void SetValue(float value)
    {
        hpBar.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, MaxHP * value);
    }
}