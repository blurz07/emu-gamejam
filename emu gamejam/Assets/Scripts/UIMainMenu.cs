using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] Button _startButton;
    [SerializeField] Button _optionsButton;
    [SerializeField] Button _quitButton;

    void Start()
    {
        _startButton.onClick.AddListener(StartGame);
        _optionsButton.onClick.AddListener(OpenOptions);
        _quitButton.onClick.AddListener(QuitGame);
    }

    private void StartGame()
    {
        ScenesManager.Instance.LoadNewGame();
    }

    private void OpenOptions()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.Options);
    }

    private void QuitGame()
    {
        Application.Quit();
    }
}
