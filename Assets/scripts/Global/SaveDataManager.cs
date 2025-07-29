using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

/*
 * GlobalData�� �����ص� �����ִ� ������
 * LocalData�� ������ ���� �ʱ�ȭ �� ������
*/

public class SaveManager : MonoBehaviour
{
    public static SaveManager Instance;  // �̱���

    public GlobalData Globaldata = new GlobalData();
    public LocalData Localdata = new LocalData();

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);  // �� ��ȯ �ÿ��� ����
        }
        else
        {
            Destroy(gameObject);  // �ߺ� ����
        }
    }

    void Start()
    {
        LoadGame();
        SaveGame();
        Debug.Log(Application.persistentDataPath);
    }

    public void SaveGame()
    {
        string Gjson = JsonUtility.ToJson(Globaldata);
        File.WriteAllText(Application.persistentDataPath + "/GlobalData.json", Gjson);

        string Ljson = JsonUtility.ToJson(Localdata);
        File.WriteAllText(Application.persistentDataPath + "/LocalData.json", Ljson);

        Debug.Log("���̺굥����ȣ���");
    }

    public void LoadGame()  // ������ ���µ� �ε�Ǹ� �׳� ����Ʈ �������� ��
    {
        string Gpath = Application.persistentDataPath + "/GlobalData.json";
        if (File.Exists(Gpath))
        {
            string json = File.ReadAllText(Gpath);
            Globaldata = JsonUtility.FromJson<GlobalData>(json);
        }

        string Lpath = Application.persistentDataPath + "/LocalData.json";
        if (File.Exists(Lpath))
        {
            string json = File.ReadAllText(Lpath);
            Localdata = JsonUtility.FromJson<LocalData>(json);
        }

        Debug.Log("�ε嵥����ȣ���");
    }

    public void ResetGame()  // LocalData�� �ʱ�ȭ
    {
        Debug.Log("���°���ȣ���");
        SaveManager.Instance.Localdata = new LocalData();  // �ν��Ͻ� �ʱ�ȭ

        string path = Application.persistentDataPath + "/LocalData.json";
        if (File.Exists(path))
            File.Delete(path);

        SaveGame();
    }
}