using System.Collections;
using System.Collections.Generic;
using System;


[Serializable]
public class LocalData
{
    public string playerName;  // �÷��̾� �̸�
    public bool first_play;  // ���� �� ù ��° �÷�������

    public LocalData()
    {
        playerName = "test";
        first_play = true;
    }
}

[Serializable]
public class GlobalData
{
    public int[] count_clear;  // � ����� �� �� Ŭ���� �ߴ���
    public bool[] achievement;  // � ������ Ŭ���� �ߴ���
    public int lastest_window_mode;

    public GlobalData()
    {
        count_clear = new int[] { 0, 0, 0 };
        achievement = new bool[] { false, false };
        lastest_window_mode = 0;
    }
}

