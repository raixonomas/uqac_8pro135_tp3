using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Parameter : MonoBehaviour
{
    DropdownField dropResolution;
    Toggle togFullScreen;
    DropdownField dropQuality;
    SliderInt sliderVolume;

    public delegate void VolumeEvent(float volume);
    public static event VolumeEvent OnChangeVolume;

    // Start is called before the first frame update
    void Start()
    {
        var ui = GetComponent<UIDocument>();
        var rootVisualElement = ui.rootVisualElement;

        if (rootVisualElement != null)
        {
            dropResolution = rootVisualElement.Q<DropdownField>("dropResolution");
            togFullScreen = rootVisualElement.Q<Toggle>("togFullScreen");
            dropQuality = rootVisualElement.Q<DropdownField>("dropQuality");
            sliderVolume = rootVisualElement.Q<SliderInt>("sliderVolume");

            dropResolution.choices = GetResolution();
            dropResolution.value = Screen.currentResolution.width.ToString() + "x" + Screen.currentResolution.height.ToString();
            dropResolution.RegisterValueChangedCallback(x => dropResolution_ValueChanged());

            togFullScreen.value = Screen.fullScreen;
            togFullScreen.RegisterValueChangedCallback(x => togFullScreen_ValueChanged());

            dropQuality.choices = GetQuality();
            dropQuality.value = GetCurrentQuality();
            dropQuality.RegisterValueChangedCallback(x => dropQuality_ValueChanged());

            sliderVolume.value = (int)AudioListener.volume;
            sliderVolume.RegisterValueChangedCallback(x => sliderVolue_ValueChanged());

            var btnBack = rootVisualElement.Q<Button>("btnBack");

            btnBack.RegisterCallback<ClickEvent>(x => btnBack_Click());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private List<string> GetResolution()
    {
        return Screen.resolutions.Select(resolution => { return resolution.width + "x" + resolution.height; }).ToList();
    }

    private List<string> GetQuality()
    {
        return new List<string>() { "Basse", "Moyenne", "Haute" };
    }

    private string GetCurrentQuality()
    {
        switch (QualitySettings.GetQualityLevel())
        {
            case 1:
                return "Basse";
            case 2:
                return "Moyenne";
            case 3:
                return "Haute";
            default:
                return "Basse";
        }
    }

    private void dropQuality_ValueChanged()
    {
        string quality = dropQuality.value;

        switch (quality)
        {
            case "Basse":
                QualitySettings.SetQualityLevel(1);
                break;
            case "Moyenne":
                QualitySettings.SetQualityLevel(2);
                break;
            case "Haute":
                QualitySettings.SetQualityLevel(3);
                break;
        }
    }

    private void dropResolution_ValueChanged()
    {
        int width = Convert.ToInt32(dropResolution.value.Split("x").First());
        int height = Convert.ToInt32(dropResolution.value.Split("x").Last());
        Screen.SetResolution(width, height, togFullScreen.value);
    }

    private void sliderVolue_ValueChanged()
    {
        var value = sliderVolume.value / 100f;
        AudioListener.volume = value;
    }

    private void togFullScreen_ValueChanged()
    {
        Screen.fullScreen =  togFullScreen.value;
    }

    private void btnBack_Click()
    {
        SceneManager.LoadScene("Menu");
    }
}
