using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour
{
    public void Play(int  index)
    {
        SceneManager.LoadScene(index);
    }
    public void Quitbutton()
    {
        Application.Quit();
    }
}
