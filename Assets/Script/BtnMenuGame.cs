using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#if UNITY_EDITOR
#endif
public class Btn : MonoBehaviour
{

    public void NextMenu()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitGame()
    {
        #if UNITY_EDITOR
        // Dừng Play Mode 
        EditorApplication.isPlaying = false;
        #else
        // Thoát khỏi game
        Application.Quit();
        #endif
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
