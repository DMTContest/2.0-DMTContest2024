using System.Collections;
using System.Collections.Generic;
using TMPro;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeTX1 : MonoBehaviour
{
    float local_score;//��ǰ�ؿ���ʵʱ�÷�

    //����ģʽ��Ҫ������
    public float timeStart = 60f;//�ӵ���ģʽ�л�ȡ����һ�ؿ��м̳еĵ���ʱ
    public float sceneiswrong = 0;//��һ��������ٴ�
    public Text textBox;//�󶨵���ʱ���ı�
    public Text textLost;//�󶨵���ʱ���ı�

    // Start is called before the first frame update
    void Start()
    {
        TimeLostFalse();
        //����ʱϵͳ
        StartCoroutine(CountdownRoutine());

    }

    // Update is called once per frame
    void Update()
    {

    }

    //����ʱϵͳ
    IEnumerator CountdownRoutine()
    {
        while (timeStart > 0f)
        {
            textBox.text = Mathf.Round(timeStart).ToString();
            UpdateUI(); // ����UI
            yield return new WaitForSeconds(1f);
            timeStart -= 1f;
        }
        textBox.text = "0";
        UpdateUI(); // ȷ������ʱ��Ϊ0ʱҲ����UI
        Debug.Log("����ʱ������");
        SceneManager.LoadScene("IGTimeOver");
    }

    void UpdateUI()
    {
        // ȷ�������߳��ϸ���UI
        if (textBox != null)
        {
            textBox.text = Mathf.Round(timeStart).ToString() + "s";
        }
    }
    // ���ٵ���ʱ�ķ���
    public void ReduceTime(float amount)
    {
        timeStart -= amount;
        if (timeStart < 0f)
        {
            timeStart = 0f;
        }
        TimeLostOnce();
        Invoke("TimeLostFalse", 0.5f);

        UpdateUI(); // ÿ�μ���ʱ��ʱ����UI
    }
    public void TimeLostOnce()
    {
        textLost.gameObject.SetActive(true);
    }

    public void TimeLostFalse()
    {
        textLost.gameObject.SetActive(false);
    }
}
