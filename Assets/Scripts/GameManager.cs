using UnityEngine;

public class GameManager : MonoBehaviour {
    private int _levelIndex;
    [SerializeField] private int levelIndex;

    private void Start() {
        _levelIndex = PlayerPrefs.GetInt("levelIndex");
        LoadLevel();
    }

    private void OnEnable() {
        _levelIndex = levelIndex;
        PlayerPrefs.SetInt("levelIndex", 0);
    }

    private void LoadLevel() {
        var model = Resources.Load<GameModel>("gameModel");
        print(_levelIndex);
        foreach (var obj in model.levels[_levelIndex].levelObjs)
            Instantiate(obj.gameObject, obj.position, Quaternion.identity);
    }

    public void IncrementLevel() {
        print("Game won!");
        PlayerPrefs.SetInt("levelIndex", _levelIndex + 1);
        LoadLevel();
    }
}