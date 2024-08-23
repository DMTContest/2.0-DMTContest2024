using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JiMu7 : MonoBehaviour
{
    private bool isChoose = false;
    public TimeJG7 timeJG7; // 倒计时管理器的引用
    private JiMu7 AOption; // 00选项的脚本引用
    private JiMu7 BOption; // 01选项的脚本引用
    private JiMu7 COption; // 10选项的脚本引用
    private JiMu7 DOption; // 00选项的脚本引用
    private JiMu7 EOption; // 01选项的脚本引用
    private JiMu7 FOption; // 10选项的脚本引用
    private JiMu7 GOption; // 00选项的脚本引用
    private JiMu7 HOption; // 01选项的脚本引用
    private JiMu7 IOption; // 10选项的脚本引用
    private JiMu7 JOption; // 00选项的脚本引用
    private JiMu7 KOption; // 01选项的脚本引用
    private JiMu7 LOption; // 10选项的脚本引用

    public float correct = 0;
    public float wrong = 0;
    private JiMu7 CorrectAnswer;
    private JiMu7 WrongAnswer1;
    private JiMu7 WrongAnswer2;
    private JiMu7 WrongAnswer3;
    private JiMu7 WrongAnswer4;
    private JiMu7 WrongAnswer5;
    private JiMu7 WrongAnswer6;
    private JiMu7 WrongAnswer7;
    private JiMu7 WrongAnswer8;
    private JiMu7 WrongAnswer9;
    private JiMu7 WrongAnswer10;
    private JiMu7 WrongAnswer11;
    private JiMu7 WrongAnswer12;
    private void Start()
    {
        //Debug.Log("正在调用答案检查器");

        // 获取当前Button的Image组件


        // 获得选项的脚本引用——
        GameObject OA = GameObject.Find("Button-1");

        AOption = OA.GetComponent<JiMu7>();

        GameObject OB = GameObject.Find("Button-1 (1)");

        BOption = OB.GetComponent<JiMu7>();

        GameObject OC = GameObject.Find("Button-1 (2)");

        COption = OC.GetComponent<JiMu7>();
        GameObject OD = GameObject.Find("Button-1 (3)");

        DOption = OD.GetComponent<JiMu7>();
        GameObject OE = GameObject.Find("Button-1 (4)");

        EOption = OE.GetComponent<JiMu7>();

        GameObject OF = GameObject.Find("Button-1 (5)");

        FOption = OF.GetComponent<JiMu7>();

        GameObject OG = GameObject.Find("Button-1 (6)");

        GOption = OG.GetComponent<JiMu7>();
        GameObject OH = GameObject.Find("Button-1 (7)");

        HOption = OH.GetComponent<JiMu7>();

        GameObject OI = GameObject.Find("Button-1 (8)");

        IOption = OI.GetComponent<JiMu7>();

        GameObject OJ = GameObject.Find("Button-1 (9)");

        JOption = OJ.GetComponent<JiMu7>();
        GameObject OK = GameObject.Find("Button-1 (10)");

        KOption = OK.GetComponent<JiMu7>();
        GameObject OL = GameObject.Find("Button-1 (11)");

        LOption = OL.GetComponent<JiMu7>();
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
    public void OnButtonClickE()
    {
        isChoose = false;


        // 检查答案
        CheckAnswer();
    }
    public void OnButtonClickF()
    {
        // 切换选择状态
        isChoose = !isChoose;
       
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
            COption.isChoose == false &&
            DOption.isChoose == false &&
            EOption.isChoose == false &&
            FOption.isChoose == true &&
            GOption.isChoose == false &&
            HOption.isChoose == false &&
            IOption.isChoose == false &&
            JOption.isChoose == false &&
            KOption.isChoose == false &&
            LOption.isChoose == false)

        {
            Debug.Log("答对啦!");
            FOption.correct = 1;
            TG2Instance.instance.HCorrect1 = FOption.correct;
            SceneManager.LoadScene("JiMu8");
        }
        else
        {
            Debug.Log("答错啦!");

            timeJG7.ReduceTime(10f);

            AOption.wrong += 1;


        }
    }
}
