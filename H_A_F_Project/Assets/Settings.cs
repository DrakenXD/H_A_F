using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    public SettingsData configdata;
    public Slider volume;
    public AudioMixer mixer;

    // Start is called before the first frame update
    void Start()
    {
        volume.value = configdata.VolumeData;

        mixer.SetFloat("Musica", Mathf.Log10(configdata.VolumeData) * 20);

    }

    public void SetVolume(float vol)
    {
        configdata.VolumeData = vol;
        volume.value = vol;


        mixer.SetFloat("Musica", Mathf.Log10(vol) * 20);
    }
}
