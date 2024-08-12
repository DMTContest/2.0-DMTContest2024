using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pintu1 : MonoBehaviour
{
    public Countdown countdown;
    public Button[] choiceButtons; // 选择按钮数组
    public Image silhouetteImage1; // 第一个剪影图片
    public Image silhouetteImage2; // 第二个剪影图片
    public Image silhouetteImage3; // 第三个剪影图片
    public Image silhouetteImage4; // 第四个剪影图片

    private int correctButtonIndex1 = 0; // 第一个正确按钮的索引
    private int correctButtonIndex2 = 1; // 第二个正确按钮的索引
    private int correctButtonIndex3 = 3; // 第三个正确按钮的索引
    private int correctButtonIndex4 = 5; // 第四个正确按钮的索引

    private bool buttonClicked1 = false; // 记录第一个按钮是否被点击
    private bool buttonClicked2 = false; // 记录第二个按钮是否被点击
    private bool buttonClicked3 = false; // 记录第三个按钮是否被点击
    private bool buttonClicked4 = false; // 记录第四个按钮是否被点击

    void Start()
    {
        // 添加点击事件监听器
        for (int i = 0; i < choiceButtons.Length; i++)
        {
            int index = i; // 保存当前索引以便在闭包中使用
            choiceButtons[i].onClick.AddListener(() => OnChoiceButtonClicked(index));
        }
    }

    void OnChoiceButtonClicked(int buttonIndex)
    {
        // 判断点击的按钮是否是正确的按钮
        if (buttonIndex == correctButtonIndex1)
        {
            silhouetteImage1.color = Color.green; // 假设正确时剪影变白色
            buttonClicked1 = true;
        }
        else if (buttonIndex == correctButtonIndex2)
        {
            silhouetteImage2.color = Color.green; // 假设正确时剪影变白色
            buttonClicked2 = true;
        }
        else if (buttonIndex == correctButtonIndex3)
        {
            silhouetteImage3.color = Color.green; // 假设正确时剪影变白色
            buttonClicked3 = true;
        }
        else if (buttonIndex == correctButtonIndex4)
        {
            silhouetteImage4.color = Color.green; // 假设正确时剪影变白色
            buttonClicked4 = true;
        }
        else
        {
            countdown.ReduceTime(10f);
        }

        CheckAllButtonsClicked();
    }

    void CheckAllButtonsClicked()
    {
        if (buttonClicked1 && buttonClicked2 && buttonClicked3 && buttonClicked4)
        {
            // 所有目标按钮都被点击了，进行页面跳转
            SceneManager.LoadScene("Pintu2"); // 替换成你的目标场景名称
        }
    }
}
