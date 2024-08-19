using System.Collections;
using System.Collections.Generic;
using TMPro;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeDG27 : MonoBehaviour
{
    float local_score;//当前关卡中实时得分

    //单例模式需要的数据
    public float timeStart ;//从单例模式中获取从上一关卡中继承的倒计时
    public Text textBox;//绑定倒计时的文本
    public Text textLost;//绑定倒计时的文本

    // Start is called before the first frame update
    void Start()
    {
        timeStart = DG2Instance.Time;
        TimeLostFalse();
        //倒计时系统
        StartCoroutine(CountdownRoutine());
        
    }

    // Update is called once per frame
    void Update()
    {

    }

//倒计时系统
    IEnumerator CountdownRoutine()
    {
        while (timeStart > 0f)
        {
            textBox.text = Mathf.Round(timeStart).ToString();
            UpdateUI(); // 更新UI
            yield return new WaitForSeconds(1f);
            timeStart -= 1f;
        }
        textBox.text = "0";
        UpdateUI(); // 确保最终时间为0时也更新UI
        Debug.Log("倒计时结束！");
        SceneManager.LoadScene("DG2TimeOver");
    }

    void UpdateUI()
    {
        // 确保在主线程上更新UI
        if (textBox != null)
        {
            textBox.text = Mathf.Round(timeStart).ToString()+"s";
        }
    }  

    public void TimeLostFalse()
    {
        textLost.gameObject.SetActive(false);}

    
    
}
