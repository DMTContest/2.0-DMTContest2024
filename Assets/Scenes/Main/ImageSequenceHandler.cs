using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ImageSequenceHandler : MonoBehaviour
{
    public Image[] images; // 图像数组
    public Text[] texts; // 文本数组
    public float delayBeforeStart = 10f; // 开始前等待的时间
    public float imageDuration = 5f; // 每个图像显示的时间

    private int currentIndex = 0; // 当前显示的图像索引
    private Coroutine sequenceCoroutine; // 用于存储序列的协程

    private void Start()
    {
        // 初始化时禁用所有图像和文本
        foreach (var img in images)
        {
            img.enabled = false;
        }
        foreach (var txt in texts)
        {
            txt.enabled = false;
        }

        // 开始延时后启动图像序列
        sequenceCoroutine = StartCoroutine(StartSequenceAfterDelay());
    }

    private IEnumerator StartSequenceAfterDelay()
    {
        yield return new WaitForSeconds(delayBeforeStart);
        StartCoroutine(ImageSequence());
    }

    private IEnumerator ImageSequence()
    {
        while (true)
        {
            // 显示当前图像及其文本
            images[currentIndex].enabled = true;
            texts[currentIndex].enabled = true;

            // 等待指定的时间
            yield return new WaitForSeconds(imageDuration);

            // 隐藏当前图像及其文本
            images[currentIndex].enabled = false;
            texts[currentIndex].enabled = false;

            // 更新当前图像索引
            currentIndex = (currentIndex + 1) % images.Length;
        }
    }
}