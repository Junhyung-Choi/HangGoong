using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowNextText : MonoBehaviour
{
    public GameObject textbox;
    public string [] dialog = new string[30] {
        "대사 1",
        "대사 2",
        "대사 3",
        "대사 4",
        "대사 5",
        "대사 6",
        "대사 7",
        "대사 8",
        "대사 9",
        "대사 10",
        "대사 11",
        "대사 12",
        "대사 13",
        "대사 14",
        "대사 15",
        "대사 16",
        "대사 17",
        "대사 18",
        "대사 19",
        "대사 20",
        "대사 21",
        "대사 22",
        "대사 23",
        "대사 24",
        "대사 25",
        "대사 26",
        "대사 27",
        "대사 28",
        "대사 29",
        "대사 30"
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
        textbox.GetComponent<Text>().text = dialog[index++];
    }
}
