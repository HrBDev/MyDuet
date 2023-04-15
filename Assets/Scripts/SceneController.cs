using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void RestartScene() {
        SceneManager.LoadScene("SampleScene");
    }
}
