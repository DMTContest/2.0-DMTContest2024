using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FangKuai7 : MonoBehaviour
{
    public Button[] buttons; // 按钮数组或其他点击物体的数组
    private bool[] buttonStates; // 按钮状态数组
    public TimeFG7 timeFG7; // 引用到 Countdown 脚本
    private bool isChoose = false;


    private FangKuai7 AOption; // 00选项的脚本引用
    private FangKuai7 BOption; // 01选项的脚本引用
    private FangKuai7 COption; // 10选项的脚本引用
    private FangKuai7 DOption; // 10选项的脚本引用


    public float correct = 0;
    public float wrong = 0;
    private FangKuai7 CorrectAnswer;
    private FangKuai7 WrongAnswer1;
    private FangKuai7 WrongAnswer2;
    private FangKuai7 WrongAnswer3;

    void OnButtonClicked(int buttonIndex)
    {
        // 更新按钮状态并检查是否所有按钮都已点击
        buttonStates[buttonIndex] = true;
        buttons[buttonIndex].gameObject.SetActive(false); // 隐藏按钮

        CheckAllButtonsClicked();
    }

    void CheckAllButtonsClicked()
    {
        foreach (bool state in buttonStates)
        {
            if (!state) return;
        }

        // 所有按钮都被点击了，进行页面跳转
        SceneManager.LoadScene("FangKuai8"); // 替换成你的目标场景名称
    }

    // IPointerClickHandler method
    public void OnPointerClick(PointerEventData eventData)
    {
        // Check if the clicked object is not in the buttons array
        GameObject clickedObject = eventData.pointerPress;
        bool isButton = System.Array.Exists(buttons, button => button.gameObject == clickedObject);

        if (!isButton)
        {
            // Reduce time by 10 seconds
            if (timeFG7 != null)
            {
                timeFG7.ReduceTime(10f);
            }
        }
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

        AOption = OA.GetComponent<FangKuai7>();

        GameObject OB = GameObject.Find("Button-2");

        BOption = OB.GetComponent<FangKuai7>();

        GameObject OC = GameObject.Find("Button-3");

        COption = OC.GetComponent<FangKuai7>();
        GameObject OD = GameObject.Find("Button-4");

        DOption = OD.GetComponent<FangKuai7>();



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
            SceneManager.LoadScene("FangKuai8");
        }
        else
        {
            Debug.Log("答错啦!");

            timeFG7.ReduceTime(10f);

            AOption.wrong += 1;


        }
    }

}