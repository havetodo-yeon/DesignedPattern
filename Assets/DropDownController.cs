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

        optionsData.Clear();    // ���� ������ ����

        for(int i = 0; i < 5; i++)
        {
            optionsData.Add(new Dropdown.OptionData(i.ToString()));
        }
        options.onValueChanged.AddListener(Check);  // ���� �ٲ� ������ check
    }

    public void Check(int index)
    {
        switch (index)
        {
            case 0:
                Debug.Log("���� �޴��� ��õ���ּ���.");
                break;
            case 1:
                Debug.Log("���� �����ϼ̽��ϴ�.");
                break;
            case 2:
                Debug.Log("�� �ȳ��ҽ��ϴ�.");
                break;
            case 3:
                Debug.Log("��!");
                break;
            case 4:
                Debug.Log("�ȳ�~~");
                break;
            default:
                return;
        }
    }

}
