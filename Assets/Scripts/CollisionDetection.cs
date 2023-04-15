using UnityEngine;

public class CollisionDetection : MonoBehaviour {
    public GameEvent onGameWon;
    public GameEvent onGameLost;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Finish"))
            onGameWon.TriggerEvent();
        else
            onGameLost.TriggerEvent();
    }
}