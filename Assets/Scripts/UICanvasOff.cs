using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICanvasOff : MonoBehaviour
{
    public static bool isOpened = false;
    public GameObject Canvas;
    public GameObject onCanvas;
    public void turnoff()
    {
        isOpened = true;
        Canvas.SetActive(false);
        onCanvas.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        if(UICanvasOff.isOpened)
        {
            turnoff();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
