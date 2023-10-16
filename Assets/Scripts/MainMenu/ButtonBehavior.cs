using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class ButtonBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var ui = GetComponent<UIDocument>();
        var rootVisualElement = ui.rootVisualElement;

        if (rootVisualElement != null)
        {
            var btnPlay = rootVisualElement.Q<Button>("btnPlay");
            var btnParameter = rootVisualElement.Q<Button>("btnParameter");
            var btnQuit = rootVisualElement.Q<Button>("btnQuit");
            var lblVersion = rootVisualElement.Q<Label>("lblVersion");

            btnPlay.RegisterCallback<ClickEvent>(x => btnPlay_Click());
            btnParameter.RegisterCallback<ClickEvent>(x => btnParameter_Click());
            btnQuit.RegisterCallback<ClickEvent>(x => btnQuit_Click());
            lblVersion.text = GetVersion();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void btnPlay_Click()
    {
        SceneManager.LoadScene("Level_1");
    }
    private void btnParameter_Click()
    {
        SceneManager.LoadScene("Parameter");
    }
    private void btnQuit_Click()
    {
        Application.Quit();
    }
    private string GetVersion()
    {
        return Application.version;
    }
}
