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
        // onValueChanged.AddLister()는 슬라이더의 onValueChanged에 기능을 추가하려는 함수
        // delegate를 통해 넘기는 것이 가능합니다.
        // 버튼의 onClick도 AddLister기능이 있습니다.
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
