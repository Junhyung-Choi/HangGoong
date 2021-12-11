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

    void Start()
    {
        g_color = White;
    }

    public static void changeAllColors(GameObject ceramic)
    {
        Renderer ren = ceramic.GetComponent<Renderer>();
        Material[] mat = ren.materials;
        mat[0] = g_color;
        if (ceramic.name.Equals("44") || ceramic.name.Equals("55") || ceramic.name.Equals("66"))
        {
            Debug.Log("why");
            mat[0].mainTextureScale = new Vector2(15,1);
        }
        else
        {
            Debug.Log(ceramic.name);
            mat[0].mainTextureScale = new Vector2(4,4);
        }
        ren.materials = mat;
        
        // Renderer ren = GameObject.Find("11").GetComponent<Renderer>();
        // Material[] mat = ren.materials;
        // mat[0] = g_color;
        // ren.materials = mat;
        // ren = GameObject.Find("22").GetComponent<Renderer>();
        // mat = ren.materials;
        // mat[0] = g_color;
        // ren.materials = mat;
        // ren = GameObject.Find("33").GetComponent<Renderer>();
        // mat = ren.materials;
        // mat[0] = g_color;
        // ren.materials = mat;
        // ren = GameObject.Find("44").GetComponent<Renderer>();
        // mat = ren.materials;
        // mat[0] = g_color;
        // ren.materials = mat;
        // ren = GameObject.Find("55").GetComponent<Renderer>();
        // mat = ren.materials;
        // mat[0] = g_color;
        // ren.materials = mat;
        // ren = GameObject.Find("66").GetComponent<Renderer>();
        // mat = ren.materials;
        // mat[0] = g_color;
        // ren.materials = mat;
        // ren = GameObject.Find("77").GetComponent<Renderer>();
        // mat = ren.materials;
        // mat[0] = g_color;
        // ren.materials = mat;


        // GameObject.Find("77").GetComponent<MeshRenderer>().material = g_color;
    }
}
