using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting; // 这个命名空间在这个脚本中没有被使用到。
using UnityEngine;

public class Balloon : MonoBehaviour
{
    // 公开的序列化字段，可以在 Unity 编辑器中轻松调整。
    [SerializeField] private int number; // 圆形的唯一编号。
    [SerializeField] private Vector3 startPosition = new Vector3(1f, -10f, 0); // 圆形的起始位置。
    [SerializeField] private float initialRate = 0.5f; // 圆形初始增长速度。
    [SerializeField] private float decayRate = 0.1f; // 超过阈值后增长速度衰减率。
    [SerializeField] private float timeInterval = 0.2f; // 增长间隔时间。
    [SerializeField] private float maxScale = 3.0f; // 圆形最大可达到的比例。
    [SerializeField] private Vector3 initialScale = new Vector3(1.0f, 1.0f, 1.0f); // 圆形初始比例。
    [SerializeField] private float thresholdScale = 2.0f; // 达到此比例后开始衰减增长速度。
    [SerializeField] private float moveAmplitudeX = 1.0f; // 水平移动幅度。
    [SerializeField] private float moveAmplitudeY = 1.0f; // 垂直移动幅度。
    [SerializeField] private float moveFrequency = 1.0f; // 移动频率。
    [SerializeField] private float rotationSpeed = 30.0f; // 绕前向轴旋转速度。

    // 私有变量。
    private float currentScaleValue = 0f; // 圆形当前的比例值。
    private float timeElapsed = 0f; // 自启动以来经过的时间。
    private bool isEliminated = false; // 标记圆形是否已被消除。

    private void Start()
    {
        // 设置圆形的起始位置和比例。
        transform.position = startPosition;
        transform.localScale = initialScale;
        
        // 初始化当前比例值。
        currentScaleValue = initialScale.x;
        
        // 开始周期性调用 IncreaseScale 方法，每 timeInterval 秒调用一次。
        InvokeRepeating("IncreaseScale", 0f, timeInterval);
    }

    private void IncreaseScale()
    {
        // 如果圆形已经被消除，则退出方法。
        if (isEliminated) return;

        // 计算比例增加量。
        float scaleIncrement;
        if (currentScaleValue < thresholdScale)
        {
            // 如果当前比例小于阈值，则使用初始增长速度。
            scaleIncrement = initialRate;
        }
        else
        {
            // 如果当前比例超过阈值，则使用衰减后的增长速度。
            scaleIncrement = initialRate * Mathf.Exp(-decayRate * (currentScaleValue - thresholdScale));
        }

        // 更新当前比例值。
        currentScaleValue += scaleIncrement;
        
        // 如果当前比例值达到了最大值，则停止增长并设置为最大值。
        if (currentScaleValue >= maxScale)
        {
            CancelInvoke("IncreaseScale"); // 取消定时器。
            currentScaleValue = maxScale;
        }

        // 更新圆形的比例。
        transform.localScale = new Vector3(currentScaleValue, currentScaleValue, 1f);

        // 更新已过时间。
        timeElapsed += Time.deltaTime;

        // 使用正弦函数计算新的 x 和 y 位置。
        float newX = timeElapsed * moveAmplitudeX * moveFrequency + moveAmplitudeX * Mathf.Cos(timeElapsed * moveFrequency);
        float newY = timeElapsed * moveAmplitudeY * moveFrequency + moveAmplitudeY * Mathf.Sin(timeElapsed * moveFrequency);

        // 更新圆形的位置。
        transform.position = new Vector3(newX, newY, transform.position.z);

        // 绕前向轴旋转圆形。
        transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed);
    }

    private void OnMouseDown()
    {
        // 如果圆形已经被消除，则退出方法。
        if (isEliminated) return;

        // 查找 GameManager 实例。
        GameManager gameManager = FindObjectOfType<GameManager>();

        if (gameManager != null)
        {
            // 通知 GameManager 此圆形被点击了。
            gameManager.OnCircleClicked(number);
        }
    
        // 标记圆形为已消除，并销毁圆形 GameObject。
        isEliminated = true;
        Destroy(gameObject);
    }
}