using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class ButtonDirector : MonoBehaviour
{
    void Start()
    {
        
    }

    public void StartButtonClicked()
    {
        Debug.Log("StartButtonClicked ½ÇÇàµÊ");
        SceneManager.LoadScene("SelectScene");
    }

    void Update()
    {
        
    }
}
