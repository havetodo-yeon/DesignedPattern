using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MixerTester : MonoBehaviour
{
    public AudioMixer MyMixer;
    public Slider slider;

    private void Awake()
    {
        slider.onValueChanged.AddListener(delegate { AudioControll(); });
        // onValueChanged.AddLister()�� �����̴��� onValueChanged�� ����� �߰��Ϸ��� �Լ�
        // delegate�� ���� �ѱ�� ���� �����մϴ�.
        // ��ư�� onClick�� AddLister����� �ֽ��ϴ�.
    }

    public void AudioControll()
    {
        float sound = slider.value;
        if (sound == -40.0f)
        {
            MyMixer.SetFloat("BGM", -80);
        }
        else
        {
            MyMixer.SetFloat("BGM", sound);
        }
    }

    public void ToggleAudio()
    {
        AudioListener.volume = AudioListener.volume == 0 ? 1 : 0;
    }

}
