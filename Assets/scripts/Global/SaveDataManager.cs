using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

/*
 * GlobalData는 리셋해도 남아있는 데이터
 * LocalData는 엔딩을 보면 초기화 될 데이터
*/

public class SaveManager : MonoBehaviour
{
    public static SaveManager Instance;  // 싱글톤

    public GlobalData Globaldata = new GlobalData();
    public LocalData Localdata = new LocalData();

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);  // 씬 전환 시에도 유지
        }
        else
        {
            Destroy(gameObject);  // 중복 방지
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

        Debug.Log("세이브데이터호출됨");
    }

    public void LoadGame()  // 파일이 없는데 로드되면 그냥 디폴트 설정으로 감
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

        Debug.Log("로드데이터호출됨");
    }

    public void ResetGame()  // LocalData만 초기화
    {
        Debug.Log("리셋게임호출됨");
        SaveManager.Instance.Localdata = new LocalData();  // 인스턴스 초기화

        string path = Application.persistentDataPath + "/LocalData.json";
        if (File.Exists(path))
            File.Delete(path);

        SaveGame();
    }
}