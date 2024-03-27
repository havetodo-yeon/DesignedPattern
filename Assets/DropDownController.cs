using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownController : MonoBehaviour
{
    public Dropdown options;

    List<Dropdown.OptionData> optionsData;

    private void Start()
    {
        optionsData = options.options;

        optionsData.Clear();    // 기존 데이터 삭제

        for(int i = 0; i < 5; i++)
        {
            optionsData.Add(new Dropdown.OptionData(i.ToString()));
        }
        options.onValueChanged.AddListener(Check);  // 값이 바뀔 때마다 check
    }

    public void Check(int index)
    {
        switch (index)
        {
            case 0:
                Debug.Log("저녁 메뉴좀 추천해주세요.");
                break;
            case 1:
                Debug.Log("오늘 수고하셨습니다.");
                break;
            case 2:
                Debug.Log("얼마 안남았습니다.");
                break;
            case 3:
                Debug.Log("꽝!");
                break;
            case 4:
                Debug.Log("안녕~~");
                break;
            default:
                return;
        }
    }

}
