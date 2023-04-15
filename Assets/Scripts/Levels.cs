using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "config", menuName = "con")]
public class Levels : ScriptableObject {
    [FormerlySerializedAs("Harchis")] public List<LevelObj> levelObjs = new();
}

[Serializable]
public struct LevelObj {
    [FormerlySerializedAs("GameObject")] public GameObject gameObject;
    public Vector3 position;
}