using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlay : MonoBehaviour
{
    void Start()
    {
  
    }
    void Update()
    {
      
    }
    public void ResetBtn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void homeBtn()
    {
        SceneManager.LoadScene(0);
    }
    public void NextLv()
    {
        SceneManager.LoadScene(3);
    }

}
