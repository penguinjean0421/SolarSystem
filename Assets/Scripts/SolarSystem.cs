using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SolarSystem : MonoBehaviour
{
  public float revSpeed = 0f; // 공전 속도
  public float rotSpeed = 0f; // 자전 속도
  GameObject Sun;

  void Awake()
  {
    Sun = GameObject.Find("Sun");
  }

  void Update()
  {
    // 공전
    transform.RotateAround(Sun.transform.position, Vector3.up, Time.deltaTime * revSpeed);

    // 자전
    transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);
  }
}

