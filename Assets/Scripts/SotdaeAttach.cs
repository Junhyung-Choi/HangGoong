using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SotdaeAttach : MonoBehaviour
{
    // 대가리랑 봉을 빈 부모 아래에 둬서 pivot 축 바꾸기
    // ParentSotDae GameObject에
    // 대가리 bottom 중심 좌표값 박아서 박고
    // 봉 부분 top 중심 좌표값 기록해서
    // 대가리랑 봉 부분의 box collider가 서로 충돌 판정나면
    // ParentSotDae에 지정한 좌표(localPosition/localRotation)로 붙이면 된다.
    // 우선 ParentSotDae에 자식으로 넣고
    // localPosition/localRotation을 0,0,0으로 두면 될듯!
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
