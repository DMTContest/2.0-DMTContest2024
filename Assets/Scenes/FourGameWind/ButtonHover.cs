using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class ButtonHover : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    private RectTransform rectTransform;
    private Vector3 originalScale;

    public float scaleFactor = 1.2f; // 放大的比例
    public float scaleSpeed = 0.2f; // 放大缩小的速度

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        originalScale = rectTransform.localScale;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        StopAllCoroutines();
        StartCoroutine(ScaleButton(rectTransform.localScale, originalScale * scaleFactor));
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        StopAllCoroutines();
        StartCoroutine(ScaleButton(rectTransform.localScale, originalScale));
    }

    private IEnumerator ScaleButton(Vector3 startScale, Vector3 endScale)
    {
        float elapsedTime = 0f;

        while (elapsedTime < scaleSpeed)
        {
            rectTransform.localScale = Vector3.Lerp(startScale, endScale, (elapsedTime / scaleSpeed));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        rectTransform.localScale = endScale;
    }
}
