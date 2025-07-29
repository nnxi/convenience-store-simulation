using System.Collections;
using System.Collections.Generic;
using System;


[Serializable]
public class LocalData
{
    public string playerName;  // 플레이어 이름
    public bool first_play;  // 리셋 후 첫 번째 플레이인지

    public LocalData()
    {
        playerName = "test";
        first_play = true;
    }
}

[Serializable]
public class GlobalData
{
    public int[] count_clear;  // 어떤 상권을 몇 번 클리어 했는지
    public bool[] achievement;  // 어떤 업적을 클리어 했는지
    public int lastest_window_mode;

    public GlobalData()
    {
        count_clear = new int[] { 0, 0, 0 };
        achievement = new bool[] { false, false };
        lastest_window_mode = 0;
    }
}

