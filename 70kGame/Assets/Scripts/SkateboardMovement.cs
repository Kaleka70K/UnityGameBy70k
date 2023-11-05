using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SkateboardMovement : MonoBehaviour
{
    public int speed;
    public float rotationSpeed = 100f;

    private void Update()
    {
   
        // ����������� ���������� ������/�����
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // ������� ���������� �����/������
        float rotationY = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0f, rotationY, 0f);
    }
}

