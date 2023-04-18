using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    private int _levelIndex;
    [SerializeField] private int levelIndex;

    private void Start() {
        _levelIndex = PlayerPrefs.GetInt("levelIndex");
        LoadLevel();
    }

    private void OnEnable() {
        _levelIndex = levelIndex;
        //PlayerPrefs.SetInt("levelIndex", 0);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PlayerPrefs.SetInt("levelIndex", 0);
            SceneManager.LoadScene("SampleScene");
        }
    }
    private void LoadLevel() {
        var model = Resources.Load<GameModel>("gameModel");
        _levelIndex = PlayerPrefs.GetInt("levelIndex");
        print(_levelIndex);

        foreach (var obj in model.levels[_levelIndex].levelObjs)
            Instantiate(obj.gameObject, obj.position, Quaternion.identity);
        
    }

    public void IncrementLevel() {
        print("Game won!");
        int levelIndex = PlayerPrefs.GetInt("levelIndex");
        PlayerPrefs.SetInt("levelIndex", levelIndex + 1);
        SceneManager.LoadScene("SampleScene");

        //LoadLevel();
    }
}