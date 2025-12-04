using UnityEngine;
using UnityEngine.SceneManagement;

public class menuCoisas : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Comessa()
    {
        SceneManager.LoadScene("GameScene");
    }

        public void sai()
    {
        Application.Quit();
    }

        public void menu()
    {
        SceneManager.LoadScene("lel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
