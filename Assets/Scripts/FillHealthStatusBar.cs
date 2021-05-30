using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillHealthStatusBar : MonoBehaviour
{
    public Health Health;
    public Image fillImage;
    private Slider slider;

    void Awake()
    {
        slider = GetComponent<Slider>();  
    }

    void update()
    
    {
        float fillvalue = Health.StartingHealth / Health.StartingHealth; 
    }
}
