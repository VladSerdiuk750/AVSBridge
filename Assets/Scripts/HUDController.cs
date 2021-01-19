using UnityEngine;
using UnityEngine.SceneManagement;

public class HUDController : MonoBehaviour
{
    [SerializeField] private GameObject SettingsButton;

    [SerializeField] private GameObject StartButton;
    
    [SerializeField] private GameObject SettingsMenu;

    public void OnStartButtonClick()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }
    
    public void OpenSettingsMenu()
    { 
        StartButton.SetActive(false);
        SettingsButton.SetActive(false);
        SettingsMenu.SetActive(true);
    }
    
    public void CloseSettingsMenu()
    {
        StartButton.SetActive(true);
        SettingsButton.SetActive(true);
        SettingsMenu.SetActive(false);
    }
}
