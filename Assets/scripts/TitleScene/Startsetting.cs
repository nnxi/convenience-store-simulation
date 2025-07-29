using System.Collections.Generic;
using UnityEngine;

public class Startsetting : MonoBehaviour
{
    void Start()
    {
        switch (SaveManager.Instance.Globaldata.lastest_window_mode)
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
