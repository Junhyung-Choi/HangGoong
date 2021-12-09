using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ECeramicMaterial
    {
        BlueWhiteStrip,
        BlueWhiteFlower,
        White,
        Sand,
        vivid,
        metalic,
        BlueYellow
}

public class ChangeCeramicMaterial : MonoBehaviour
{
    public static Material g_color;
    public ECeramicMaterial cur_color;

    public Material BlueWhiteFlower;
    public Material BlueWhiteStrip;
    public Material BlueYellow;
    public Material Sand;
    public Material White;
    public Material Vivid;
    public Material Metalic;
    
    public void ChangeGlobalColor()
    {
        switch(cur_color)
        {
            case ECeramicMaterial.BlueWhiteFlower:
                g_color = BlueWhiteFlower;
                break;
            case ECeramicMaterial.BlueWhiteStrip:
                g_color = BlueWhiteStrip;
                break;
            case ECeramicMaterial.BlueYellow:
                g_color = BlueYellow;
                break;
            case ECeramicMaterial.metalic:
                g_color = Metalic;
                break;
            case ECeramicMaterial.Sand:
                g_color = Sand;
                break;
            case ECeramicMaterial.vivid:
                g_color = Vivid;
                break;
            case ECeramicMaterial.White:
                g_color = White;
                break;
        }
    }
    public static void changeAllColors()
    {
        GameObject.Find("11").GetComponent<MeshRenderer>().material = g_color;
        GameObject.Find("22").GetComponent<MeshRenderer>().material = g_color;
        GameObject.Find("33").GetComponent<MeshRenderer>().material = g_color;
        GameObject.Find("44").GetComponent<MeshRenderer>().material = g_color;
        GameObject.Find("55").GetComponent<MeshRenderer>().material = g_color;
        GameObject.Find("66").GetComponent<MeshRenderer>().material = g_color;
        GameObject.Find("77").GetComponent<MeshRenderer>().material = g_color;
    }
}
