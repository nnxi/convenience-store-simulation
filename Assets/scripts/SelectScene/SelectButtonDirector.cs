using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectButtonDirector : MonoBehaviour
{
    public GameObject SettingTab;
    void Start()
    {
        
    }

    public void newgameButtonClicked()
    {
        SaveManager.Instance.ResetGame();
        // 스토리씬으로 넘어가는 코드 추가
    }

    public void continueButtonClicked()
    {
        // 게임씬으로 넘어가는 코드 추가
    }

    public void settingButtonClicked()
    {
        SettingTab.SetActive(true);
    }

    public void R_settingButtonClicked()
    {
        SettingTab.SetActive(false);
    }

    public void BacktoTitleButtonClicked()
    {
        SceneManager.LoadScene("TitleScene");
    }

    void Update()
    {
        
    }
}
