using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowWoodEnding : MonoBehaviour
{
    public GameObject product;
    
    public Vector3 position;
    public GameObject Ending_Canvas;
    private GameObject new_one;
    private bool isRotate = false;
    public void showCraft()
    {
        GameObject table = GameObject.Find("Table");
        table.transform.position = table.transform.position + new Vector3(0,0,5);
        product.GetComponent<MeshRenderer>().enabled = false;
        Ending_Canvas.SetActive(true);
        new_one = Instantiate(product,Vector3.zero,Quaternion.Euler(Vector3.zero));
        product.SetActive(false);
        GameObject pare = new GameObject("pare");
        // GameObject.Find("Ceramic").GetComponent<CeramicSwitch>().enabled = false;
        new_one.transform.parent = pare.transform;
        pare.transform.parent = GameObject.Find("FollowLate").transform;
        pare.transform.localPosition = position;
        pare.transform.localRotation = Quaternion.Euler(0,0,0);
        new_one.transform.localPosition = Vector3.zero;
        pare.transform.localScale = new Vector3(0.3f,0.3f,0.3f);
        // new_one.transform.localRotation = Quaternion.Euler(Vector3.zero);
        // new_one.transform.Find("product").GetComponent<MeshRenderer>().enabled = false;
        isRotate = true;
        GameStateManager.roomList[0] = true;
    }

    void Update()
    {
        if (isRotate)
        {
            new_one.transform.Rotate(Vector3.up * Time.deltaTime * 50);
        }
    }
}
