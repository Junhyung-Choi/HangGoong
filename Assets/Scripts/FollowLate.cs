using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowLate : MonoBehaviour
{
    public GameObject target;

    public float offsetposX;
    public float offsetposY;
    public float offsetposZ;
    public float offsetrotX;
    public float offsetrotY;
    public float offsetrotZ;
    public float offsetrotW;
    public float DelayTime;
    
    // Update is called once per frame
    void Update()
    {
        Vector3 FixedPos = 
            new Vector3(
                target.transform.position.x + offsetposX,
                target.transform.position.y + offsetposY,
                target.transform.position.z + offsetposZ);
        transform.position = Vector3.Lerp(transform.position,FixedPos, Time.deltaTime * DelayTime);
        transform.LookAt(target.transform);
    }
        //Quaternion FixedRotation = Quaternion.Euler(0,90,0)



        /*
            new Quaternion(
                target.transform.rotation.x + offsetrotX,
                target.transform.rotation.y + offsetrotY,
                target.transform.rotation.z + offsetrotZ,
                target.transform.rotation.w + offsetrotW
            );*/
}