using UnityEngine;
using UnityEngine.UI;

public class UISoundLevelController : MonoBehaviour
{
    public Slider MusicSlider;
    public Slider FXSlider;


    private void Start()
    {
        MusicSlider.value = SoundSettings.MusicLevel;
        FXSlider.value = SoundSettings.FXLevel;
    }

    void Update()
    {
        SoundSettings.MusicLevel = MusicSlider.value;
        SoundSettings.FXLevel = FXSlider.value;
    }

}
