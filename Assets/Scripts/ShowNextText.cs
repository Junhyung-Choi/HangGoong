using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowNextText : MonoBehaviour
{
    public GameObject textbox;
    private string [] dialog = new string[] {
        "오, 이럴수가!",
        "환영합니다. 이 곳은 경기도 수원시 행궁동에 위치한 공방거리입니다.",
        "다양한 공방 체험과 제작을 통해 여러분들께 즐거움을 드리는 곳이죠.",
        "그런데, 이제는 사람들이 잘 찾아오지를 않아요.",
        "한 때는 사람들이 많이 오고 갈 때도 있었는데, 이제는 그렇지가 않습니다.",
        "다들 병에 걸려버렸거든요.전통을 잊고, 작고 네모난 화면에만 온 정신을 쏟아버리게 되는 병 . . .",
        "병은 순식간에 모든 거리와 도시를 휩쓸어버렸고,",
        "덕분에 사람들의 발걸음이 뚝 그치고 말았어요.",
        "워낙 고치기도 힘들고, 전파력도 빠른지라 저희로서는 손 쓸 엄두조차 나지가 않았습니다.",
        "그래서 저희는 이렇게 병이 들어버린 사람들을 치료해줄 수 있는",
        "힘을 가진 자를 하염없이 기다리고 있었습니다.",
        "이 상황이 계속된다면, 언젠가는 정말 돌이킬 수 없게 되어버리겠다는",
        "불길한 생각이 문득 머리를 스쳐 지나갔거든요.",
        "그저 기다릴 수 밖에 없었습니다.",
        "하루, 이틀, 한달, 일년 . . .이 자리에서 가만히 있기를 어인 10년.",
        "더 이상 희망이 보이지가 않았습니다.",
        "이제는 정말로 포기하려고 했어요.",
        "그런데, 그 마지막 날에, 모든 것을 버리려는 순간에 당신이 나타났습니다!",
        "작고 네모난 화면도 보고 있지 않고, 눈에는 총기가 돌고 있어요.",
        "올곧은 정신과 얼을 지닌 사람, 당신이 바로 제가 찾던 사람입니다.",
        "당신이라면 병든 자들을 치유해줄 수 있습니다!",
        "방법은 간단합니다. 앞에 보이시는 3 곳의 공방들 중 2 곳을 들어가신 뒤",
        " 직접 당신의 손으로 공예품을 제작하시면 됩니다.",
        "제작이 다 된 공예품에는 당신의 기운이 깃들어있기 때문에,",
        "주변 사람들을 모두 말끔하게 치유해줄 수 있을 거에요.",
        "부디 당신이 만든 작품들로 이 곳을 지켜주세요.부탁드립니다!!!"
    };

    private string[] end_dialog = new string[] {
        "잘 되어가고 있습니까??",
        "오, 이건…",
        "세상에, 이럴수가.",
        "제가 보고 있는게, 진짜 ???입니까 ??",
        "너무, 너무 오랜만이에요.",
        "이 아름다운 ???의 모양/향기/맛/등등…",
        "내가 이걸 다시 보게 될 날이 올 줄이야. 정말, 잊고있었어요.",
        "아니 잊어버리고 말았어요. 어떤 모양인지도, 무슨 색이었는지도, 어떻게 만드는지도 !!!",
        "그런데, 이제 다 기억이 돌아왔어요.",
        "보이시나요? 이 ???에서 뿜어져나오는 기운이?",
        "이것이 정말 제가 찾아 헤매던, 저를 울고 웃게 했던, 바로 그 기운입니다.",
        "기운이 다시 살아나면 창공을 활보하며 구름을 벗 삼아 자유로이 거닐고,",
        "때가 되면 빗방울이 되어 톡 토독 웃으며 사람들의 머리 위로 살며시 안부를 건넵니다.",
        "땅의 품에 안긴 기운은 구름이 걷히면 다시금 태양을 마주하러 여행을 떠나고,",
        "때가 되면 눈송이가 되어 소복소복 사람들의 발 아래로 그들의 폭신함이 되어줍니다.",
        "그겁니다. 그게 바로 치유에요. 치유이자 구원입니다.",
        "감사합니다. 당신 덕분이에요. 머지 않아 다시 이 곳에도 활기가 돌 거에요.",
        "다시 사람들이 찾아오고, 웃음 소리가 들리고, 추억을 담고는 즐거이 집으로 돌아갈 거에요.",
        "모두의 입꼬리가 하늘까지 닿을 수 있을거에요. 정말 고마워요. 다시 한번 감사드립니다.",
        "아, 이제 슬슬 돌아가실 시간인가 보네요.",
        "부디 오늘의 경험, 잊지 말아주세요.",
        "당신은 떠나도, 당신이 지켜준 저희의 전통은 여기 오롯이 남아 벅차게도 숨 쉴 거에요.",
        "앞으로도 문화와 전통을 가슴 한 켠에 고이 간직하며 살아주시면,",
        "제게 그것만한 기쁨이 있을까요?",
        "오늘 너무도 감사했습니다.",
        "조심히 돌아가세요.",
        "그리고,",
        "언제든지 또 오세요 !"
    };

    private int index;
    // Start is called before the first frame update
    void Start()
    {
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextText()
    {
        // if(UICanvasOff.isOpened())
        textbox.GetComponent<Text>().text = dialog[index++];
        Debug.Log("fuck that shit");
    }
}
