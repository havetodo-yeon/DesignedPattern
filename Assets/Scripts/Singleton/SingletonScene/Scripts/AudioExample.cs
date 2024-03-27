using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioExample : MonoBehaviour
{
    public AudioSource backAudioSource;
    public AudioSource eventAudioSource;
    public Slider backSoundSlider;
    public Slider eventSoundSlider;

    void Start()
    {
        if (backAudioSource.isPlaying) Debug.Log("����� ������Դϴ�."); //����� ��� ���� Ȯ��
        backAudioSource.volume = 0.5f;
        eventAudioSource.volume = 0.5f;
        backSoundSlider.value = 0.5f;
        eventSoundSlider.value = 0.5f;

    }

    public void EventSound()
    {
        eventAudioSource.Play();
        Debug.Log($"ȿ����");
    }

    public void MuteButton()
    {
        backAudioSource.volume = 0.0f;
        eventAudioSource.volume = 0.0f;
        backSoundSlider.value = 0.0f;
        eventSoundSlider.value = 0.0f;
        Debug.Log($"���Ұ�");
    }

    public void BackVolumeSlider()
    {
        backAudioSource.volume = backSoundSlider.value;
        Debug.Log($"����� ���� : {backAudioSource.volume}");
    }

    public void EventVolumeSlider()
    {
        eventAudioSource.volume = eventSoundSlider.value;
        Debug.Log($"ȿ���� ���� : {eventAudioSource.volume}");
    }

}
