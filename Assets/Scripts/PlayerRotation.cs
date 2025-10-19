using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    Camera _camera;

    string CameraName = "Game_Camera";

    Vector3 mousePos;

    private void Start()
    {
        _camera = GameObject.Find(CameraName).GetComponent<Camera>();
    }

    private void Update()
    {
        mousePos = _camera.ScreenToWorldPoint(Input.mousePosition);

        Vector3 pos = mousePos - transform.position;

        float rotZ = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, rotZ - 90);
    }
}
