using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenAdaptive : MonoBehaviour
{
    public CanvasScaler canvasScaler;
    
    void Update()
    {
        canvasScaler.referenceResolution = new Vector2(Screen.width, Screen.height); 
    }
}
