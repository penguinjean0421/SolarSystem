using UnityEngine;
public class CaremaMove : MonoBehaviour
{
  // 카메라 회전
  public float dpi = 400f; // 감도
  float mouseX = 0;
  float mouseY = 0;

  // 카메라 움직임
  public float moveSpeed = 0;

  void Update()
  {
    Rotate();
    Move();
  }

  void Rotate()
  {
    mouseX += Input.GetAxisRaw("Mouse X") * dpi * Time.deltaTime;
    mouseY -= Input.GetAxisRaw("Mouse Y") * dpi * Time.deltaTime;

    //Clamp를 통해 최소값 최대값을 넘지 않도록함
    mouseY = Mathf.Clamp(mouseY, -90f, 90f);

    // 각 축을 한꺼번에 계산
    transform.localRotation = Quaternion.Euler(mouseY, mouseX, 0f);
  }

  void Move()
  {
    float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime; // A & D 키
    float moveZ = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime; // W & S키
    float moveY = 0;

    if (Input.GetKey(KeyCode.E)) moveY = moveSpeed * Time.deltaTime; // E 키로 위로 이동
    if (Input.GetKey(KeyCode.Q)) moveY = -moveSpeed * Time.deltaTime; // Q 키로 아래로 이동

    transform.Translate(new Vector3(moveX, moveY, moveZ));
  }
}
