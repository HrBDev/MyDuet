using UnityEngine;

public class Movement : MonoBehaviour {
    private float _width;
    [SerializeField] private float speed = 185;

    private void Start() {
        _width = Screen.width / 2.0f;
    }

    private void Update() {
        Mouse();
        Touch();
        KeyBoard();
    }

    private void Touch() {
        if (Input.touchCount <= 0) return;
        var touchInfo = Input.GetTouch(0);
        var touchPos = touchInfo.position.x;
        // Debug.Log($"Touch Position: {touchPos}");
        if (touchPos > _width / 2f)
            RotateRight();
        else if (touchPos < _width / 2f) RotateLeft();
    }

    private void Mouse() {
        if (!Input.mousePresent) return;
        var isMouseBtnPressed = Input.GetMouseButton(0);
        var mousePos = Input.mousePosition.x;
        if (mousePos > _width / 2f && isMouseBtnPressed)
            RotateRight();
        else if (mousePos < _width / 2f && isMouseBtnPressed) RotateLeft();
    }

    private void KeyBoard() {
        if (Input.GetKey(KeyCode.A))
            RotateLeft();
        else if (Input.GetKey(KeyCode.D)) RotateRight();
    }

    private void RotateLeft() => transform.Rotate(Vector3.forward, speed * Time.deltaTime);
    private void RotateRight() => transform.Rotate(Vector3.back, speed * Time.deltaTime);
}