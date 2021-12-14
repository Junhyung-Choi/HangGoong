using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowFlowerEnding : MonoBehaviour
{
    public GameObject product;
    
    public Vector3 position;
    public GameObject Ending_Canvas;
    private GameObject new_one;
    private bool isRotate = false;
    public void showCraft()
    {
        product.GetComponent<MeshRenderer>().enabled = false;
        Ending_Canvas.SetActive(true);
        new_one = Instantiate(product,Vector3.zero,Quaternion.Euler(Vector3.zero));
        product.SetActive(false);
        // GameObject.Find("Ceramic").GetComponent<CeramicSwitch>().enabled = false;
        new_one.transform.parent = GameObject.Find("FollowLate").transform;
        new_one.transform.localPosition = position;
        new_one.transform.localRotation = Quaternion.Euler(Vector3.zero);
        // new_one.transform.Find("product").GetComponent<MeshRenderer>().enabled = false;
        isRotate = true;
    }

    void Update()
    {
        if (isRotate)
        {
            new_one.transform.Rotate(Vector3.up * Time.deltaTime * 50);
        }
    }
}
