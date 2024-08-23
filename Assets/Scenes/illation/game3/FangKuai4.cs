using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class FangKuai4 : MonoBehaviour
{
    public Button[] buttons; // 按钮数组
    private bool[] buttonStates; // 按钮状态数组
    public TimeFG4 timeFG4; // 引用到 Countdown 脚本

    private bool isChoose = false;

    private FangKuai4 AOption; // 00选项的脚本引用
    private FangKuai4 BOption; // 01选项的脚本引用
    private FangKuai4 COption; // 10选项的脚本引用
    private FangKuai4 DOption; // 10选项的脚本引用


    public float correct = 0;
    public float wrong = 0;
    private FangKuai4 CorrectAnswer;
    private FangKuai4 WrongAnswer1;
    private FangKuai4 WrongAnswer2;
    private FangKuai4 WrongAnswer3;


    void OnButtonClicked(int buttonIndex)
    {
        // 更新按钮状态并检查是否所有按钮都已点击
        buttonStates[buttonIndex] = true;
        buttons[buttonIndex].gameObject.SetActive(false); // 隐藏按钮

    }


    private void Start()
    {
        buttonStates = new bool[buttons.Length];

        for (int i = 0; i < buttons.Length; i++)
        {
            int index = i; // 保存当前索引以便在闭包中使用
            buttons[i].onClick.AddListener(() => OnButtonClicked(index));
        }

        //Debug.Log("正在调用答案检查器");

        // 获取当前Button的Image组件


        // 获得选项的脚本引用——
        GameObject OA = GameObject.Find("Button-1");

        AOption = OA.GetComponent<FangKuai4>();

        GameObject OB = GameObject.Find("Button-2");

        BOption = OB.GetComponent<FangKuai4>();

        GameObject OC = GameObject.Find("Button-3");

        COption = OC.GetComponent<FangKuai4>();

        GameObject OD = GameObject.Find("Button-4");

        DOption = OD.GetComponent<FangKuai4>();


        //Debug.Log("已经引用3个选项脚本");
    }

    public void OnButtonClickA()
    {
        isChoose = false;
        // 检查答案
        CheckAnswer();
    }
    public void OnButtonClickB()
    {
        // 切换选择状态
        isChoose = !isChoose;

        // 检查答案
        CheckAnswer();
    }

    public void OnButtonClickC()
    {

        isChoose = false;
        // 检查答案
        CheckAnswer();
    }
    public void OnButtonClickD()
    {

        isChoose = false;
        // 检查答案
        CheckAnswer();
    }

    private void CheckAnswer()
    {


        if (AOption.isChoose == false &&
             BOption.isChoose == true &&
             COption.isChoose == false &&
             DOption.isChoose == false)
        {
            Debug.Log("答对啦!");
            AOption.correct = 1;
            SceneManager.LoadScene("FangKuai5");
        }
        else
        {
            Debug.Log("答错啦!");

            timeFG4.ReduceTime(10f);

            AOption.wrong += 1;


        }
    }

}