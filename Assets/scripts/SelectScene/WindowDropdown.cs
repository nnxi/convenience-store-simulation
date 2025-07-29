using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WindowDropdown : MonoBehaviour
{
    public TMP_Dropdown WindowModeDRP;
    void Start()
    {
        WindowModeDRP.ClearOptions();

        WindowModeDRP.options.Add(new TMP_Dropdown.OptionData("Full Screen"));  // 전체화면모드
        WindowModeDRP.options.Add(new TMP_Dropdown.OptionData("Window Screen"));  // 창모드

        WindowModeDRP.value = SaveManager.Instance.Globaldata.lastest_window_mode;
        WindowModeDRP.RefreshShownValue();
    }

    public void OnDropdownEvent(int index)
    {
        switch(index)
        {
            case 0:
                Screen.SetResolution(1920, 1080, FullScreenMode.FullScreenWindow);
                break;

            case 1:
                Screen.SetResolution(1920, 1080, FullScreenMode.Windowed);
                break;
        }
    }
}
