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
        // ���丮������ �Ѿ�� �ڵ� �߰�
    }

    public void continueButtonClicked()
    {
        // ���Ӿ����� �Ѿ�� �ڵ� �߰�
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
