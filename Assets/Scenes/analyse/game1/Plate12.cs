using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate12 : MonoBehaviour
{
    [SerializeField] private Collider2D leftPlateCollider; // Reference to the Collider component of "leftplate"
    [SerializeField] private Collider2D squareCollider; // Reference to the Collider component of "Square"
    [SerializeField] private float moveSpeed;
    [SerializeField] private float duration;
    [SerializeField] private float rotationSpeed = 45f; // 每秒旋转的角度
    [SerializeField] private GameObject leftplate;
    [SerializeField] private GameObject rightplate;
    [SerializeField] private GameObject arm;
    [SerializeField] private GameObject point;
    [SerializeField] private GameObject center;




    private bool isleftplate = false;
    private float startTime;
    private float elapsed;


    private void Start()
    {
        // No need to do anything in Start
        startTime = Time.time;
    }

    private void Update()
    {
        if (isleftplate == true)
        {

            elapsed = Time.time - startTime;
            if (elapsed < duration)
            {
                // 更新位置
                leftplate.transform.Translate(Vector3.up * (moveSpeed * Time.deltaTime));
                rightplate.transform.Translate(Vector3.up * (-moveSpeed * Time.deltaTime));
                arm.transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);

                Vector3 worldPosition = center.transform.position;

                // 输出世界坐标
                //Debug.Log("物体的世界坐标是: " + worldPosition);
                point.transform.RotateAround(worldPosition, Vector3.forward,rotationSpeed*10 * Time.deltaTime);
                //point.transform.Rotate(Vector3.forward * (rotationSpeed*10) * Time.deltaTime);



            }
            else
            {
                // 如果超过了移动时间，停止移动
                enabled = false; // 停止此脚本的更新
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "leftplate")
        {

            Debug.Log("撞到" + collision.gameObject.tag);
            isleftplate = true;

        }
        else if (collision.gameObject.tag == "Square")
        {
            Debug.Log("撞到" + collision.gameObject.tag);

        }


    }
}