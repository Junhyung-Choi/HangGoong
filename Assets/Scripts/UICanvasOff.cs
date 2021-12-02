using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICanvasOff : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject onCanvas;
    public void turnoff()
    {
        Canvas.SetActive(false);
        onCanvas.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
