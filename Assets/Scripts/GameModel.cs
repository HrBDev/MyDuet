using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "gameModel", menuName = "gameModel")]
public class GameModel : ScriptableObject {
    [FormerlySerializedAs("configs")] public List<Levels> levels;
}