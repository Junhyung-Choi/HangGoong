using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SotdaeAttach : MonoBehaviour
{
    // 대가리랑 봉을 빈 부모 아래에 둬서 pivot 축 바꾸기 - 함
    // ParentSotDae GameObject에
    // 대가리 bottom 중심 좌표값 박아서 박고 
    // 봉 부분 top 중심 좌표값 기록해서
    // 대가리랑 봉 부분의 box collider가 서로 충돌 판정나면
    // ParentSotDae에 지정한 좌표(localPosition/localRotation)로 붙이면 된다
    // localPosition/localRotation을 0,0,0으로 두면 될듯!
    // Start is called before the first frame update
    
    float time = 0f;
    bool isAttached = false;

    void OnTriggerStay(Collider collider)
    {
        if(!isAttached && time > 1.0f && collider.gameObject.tag == "Attach")
        {
            AttachChild(collider.gameObject);
            isAttached = true;
        }
        time += Time.deltaTime;
    }

    void OnTriggerExit(Collider collider)
    {
        time = 0f;
    }

    void AttachChild(GameObject child)
    {
        GameObject origin = child.transform.parent.gameObject;
        GameObject new_child = Instantiate(origin, Vector3.zero,Quaternion.Euler(-90,origin.transform.localRotation.y,origin.transform.localRotation.z));
        GameObject par = new GameObject("par");
        new_child.transform.parent = par.transform;
        new_child.transform.localPosition = Vector3.zero;
        new_child.transform.localRotation = Quaternion.Euler(-90,origin.transform.localRotation.y,origin.transform.localRotation.z);
        new_child.GetComponent<OffsetGrab>().enabled = false;
        new_child.transform.GetChild(0).gameObject.SetActive(false);
        par.transform.parent = this.gameObject.transform;
        par.transform.localPosition = Vector3.zero;
        par.transform.localRotation = Quaternion.Euler(0,0,0);
        this.transform.parent.gameObject.GetComponent<BoxCollider>().center = new Vector3(0,-8,0);
        this.transform.parent.gameObject.GetComponent<BoxCollider>().size = new Vector3(4,20,4);
        origin.SetActive(false);
    }  

    void Update()
    {
        if (isAttached)
        {
            this.transform.parent.gameObject.GetComponent<Rigidbody>().useGravity = false;
            this.transform.parent.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
