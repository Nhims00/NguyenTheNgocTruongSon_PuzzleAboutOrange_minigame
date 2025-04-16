using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLv : MonoBehaviour
{
    public void BackMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void MapLv1()
    {
        SceneManager.LoadScene(2);
    }
    public void MapLv2()
    {
        SceneManager.LoadScene(3);
    }
    public void MapLv3()
    {
        SceneManager.LoadScene(4);
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
