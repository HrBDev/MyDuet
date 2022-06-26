using UnityEngine;

public class Movement : MonoBehaviour {
    [SerializeField] private float speed = 185;
    [SerializeField] private float dotSpeed = 2;
    private float _width;
    private Camera _camera;

    private void Start() {
        _width = Screen.width / 2.0f;
        _camera = Camera.main;
    }

    private void Update() {
        DotMovement();
        Mouse();
        Touch();
        KeyBoard();
    }

    private void DotMovement() {
        var position = transform.position;
        position = Vector3.Lerp(position, position + new Vector3(0, dotSpeed, 0), Time.deltaTime);
        transform.position = position;
        var camPos = _camera.transform.position;
        camPos = Vector3.Lerp(camPos, camPos + new Vector3(0, dotSpeed, 0), Time.deltaTime);
        _camera.transform.position = camPos;
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