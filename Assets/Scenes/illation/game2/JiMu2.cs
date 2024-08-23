using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JiMu2 : MonoBehaviour
{
    private bool isChoose = false;
    public TimeJG2 timeJG2; // 倒计时管理器的引用
    private JiMu2 AOption; // 00选项的脚本引用
    private JiMu2 BOption; // 01选项的脚本引用
    private JiMu2 COption; // 10选项的脚本引用
    private JiMu2 DOption; // 00选项的脚本引用
    private JiMu2 EOption; // 01选项的脚本引用
    private JiMu2 FOption; // 10选项的脚本引用
    private JiMu2 GOption; // 00选项的脚本引用
    private JiMu2 HOption; // 01选项的脚本引用
    private JiMu2 IOption; // 10选项的脚本引用
    private JiMu2 JOption; // 00选项的脚本引用
    private JiMu2 KOption; // 01选项的脚本引用
    private JiMu2 LOption; // 10选项的脚本引用

    public float correct = 0;
    public float wrong = 0;
    private JiMu2 CorrectAnswer;
    private JiMu2 WrongAnswer1;
    private JiMu2 WrongAnswer2;
    private JiMu2 WrongAnswer3;
    private JiMu2 WrongAnswer4;
    private JiMu2 WrongAnswer5;
    private JiMu2 WrongAnswer6;
    private JiMu2 WrongAnswer7;
    private JiMu2 WrongAnswer8;
    private JiMu2 WrongAnswer9;
    private JiMu2 WrongAnswer10;
    private JiMu2 WrongAnswer11;
    private JiMu2 WrongAnswer12;
    private void Start()
    {
        //Debug.Log("正在调用答案检查器");

        // 获取当前Button的Image组件


        // 获得选项的脚本引用——
        GameObject OA = GameObject.Find("Button-1");

        AOption = OA.GetComponent<JiMu2>();

        GameObject OB = GameObject.Find("Button-1 (1)");

        BOption = OB.GetComponent<JiMu2>();

        GameObject OC = GameObject.Find("Button-1 (2)");

        COption = OC.GetComponent<JiMu2>();
        GameObject OD = GameObject.Find("Button-1 (3)");

        DOption = OD.GetComponent<JiMu2>();
        GameObject OE = GameObject.Find("Button-1 (4)");

        EOption = OE.GetComponent<JiMu2>();

        GameObject OF = GameObject.Find("Button-1 (5)");

        FOption = OF.GetComponent<JiMu2>();

        GameObject OG = GameObject.Find("Button-1 (6)");

        GOption = OG.GetComponent<JiMu2>();
        GameObject OH = GameObject.Find("Button-1 (7)");

        HOption = OH.GetComponent<JiMu2>();

        GameObject OI = GameObject.Find("Button-1 (8)");

        IOption = OI.GetComponent<JiMu2>();

        GameObject OJ = GameObject.Find("Button-1 (9)");

        JOption = OJ.GetComponent<JiMu2>();
        GameObject OK = GameObject.Find("Button-1 (10)");

        KOption = OK.GetComponent<JiMu2>();
        GameObject OL = GameObject.Find("Button-1 (11)");

        LOption = OL.GetComponent<JiMu2>();
        //Debug.Log("已经引用12个选项脚本");


    }

    public void OnButtonClickA()
    {

        isChoose = false;
        // 检查答案
        CheckAnswer();
    }
    public void OnButtonClickB()
    {
        isChoose = false;
        // 检查答案
        CheckAnswer();
    }

    public void OnButtonClickC()
    {

        // 切换选择状态
        isChoose = !isChoose;

        // 检查答案
        CheckAnswer();
    }
    public void OnButtonClickD()
    {

        isChoose = false;
        // 检查答案
        CheckAnswer();
    }
    public void OnButtonClickE()
    {
        isChoose = false;
        // 检查答案
        CheckAnswer();
    }
    public void OnButtonClickF()
    {

        isChoose = false;
        // 检查答案
        CheckAnswer();
    }
    public void OnButtonClickG()
    {
        isChoose = false;
        // 检查答案
        CheckAnswer();
    }
    public void OnButtonClickH()
    {

        isChoose = false;
        // 检查答案
        CheckAnswer();
    }
    public void OnButtonClickI()
    {
        isChoose = false;
        // 检查答案
        CheckAnswer();
    }
    public void OnButtonClickJ()
    {

        isChoose = false;
        // 检查答案
        CheckAnswer();
    }
    public void OnButtonClickK()
    {
        isChoose = false;
        // 检查答案
        CheckAnswer();
    }
    public void OnButtonClickL()
    {

        isChoose = false;
        // 检查答案
        CheckAnswer();
    }
    private void CheckAnswer()
    {


        if (AOption.isChoose == false &&
            BOption.isChoose == false &&
            COption.isChoose == true &&
            DOption.isChoose == false &&
            EOption.isChoose == false &&
            FOption.isChoose == false &&
            GOption.isChoose == false &&
            HOption.isChoose == false &&
            IOption.isChoose == false &&
            JOption.isChoose == false &&
            KOption.isChoose == false &&
            LOption.isChoose == false)

        {
            Debug.Log("答对啦!");
            COption.correct = 1;
            TG2Instance.instance.JCorrect2 = COption.correct;
            SceneManager.LoadScene("JiMu3");
        }
        else
        {
            Debug.Log("答错啦!");

            timeJG2.ReduceTime(10f);

            AOption.wrong += 1;


        }
    }
}
