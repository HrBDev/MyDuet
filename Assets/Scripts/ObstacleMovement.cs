using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] private float speed = 2;

    // Update is called once per frame
    private void Update()
    {
        var position = transform.position;
        position = Vector3.Lerp(position, position - new Vector3(0, speed, 0), Time.deltaTime);
        transform.position = position;
    }
}