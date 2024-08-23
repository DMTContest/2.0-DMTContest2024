using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JiMu5 : MonoBehaviour
{
    private bool isChoose = false;
    public TimeJG5 timeJG5; // 倒计时管理器的引用
    private JiMu5 AOption; // 00选项的脚本引用
    private JiMu5 BOption; // 01选项的脚本引用
    private JiMu5 COption; // 10选项的脚本引用
    private JiMu5 DOption; // 00选项的脚本引用
    private JiMu5 EOption; // 01选项的脚本引用
    private JiMu5 FOption; // 10选项的脚本引用
    private JiMu5 GOption; // 00选项的脚本引用
    private JiMu5 HOption; // 01选项的脚本引用
    private JiMu5 IOption; // 10选项的脚本引用
    private JiMu5 JOption; // 00选项的脚本引用
    private JiMu5 KOption; // 01选项的脚本引用
    private JiMu5 LOption; // 10选项的脚本引用

    public float correct = 0;
    public float wrong = 0;
    private JiMu5 CorrectAnswer;
    private JiMu5 WrongAnswer1;
    private JiMu5 WrongAnswer2;
    private JiMu5 WrongAnswer3;
    private JiMu5 WrongAnswer4;
    private JiMu5 WrongAnswer5;
    private JiMu5 WrongAnswer6;
    private JiMu5 WrongAnswer7;
    private JiMu5 WrongAnswer8;
    private JiMu5 WrongAnswer9;
    private JiMu5 WrongAnswer10;
    private JiMu5 WrongAnswer11;
    private JiMu5 WrongAnswer12;
    private void Start()
    {
        //Debug.Log("正在调用答案检查器");

        // 获取当前Button的Image组件


        // 获得选项的脚本引用——
        GameObject OA = GameObject.Find("Button-1");

        AOption = OA.GetComponent<JiMu5>();

        GameObject OB = GameObject.Find("Button-1 (1)");

        BOption = OB.GetComponent<JiMu5>();

        GameObject OC = GameObject.Find("Button-1 (2)");

        COption = OC.GetComponent<JiMu5>();
        GameObject OD = GameObject.Find("Button-1 (3)");

        DOption = OD.GetComponent<JiMu5>();
        GameObject OE = GameObject.Find("Button-1 (4)");

        EOption = OE.GetComponent<JiMu5>();

        GameObject OF = GameObject.Find("Button-1 (5)");

        FOption = OF.GetComponent<JiMu5>();

        GameObject OG = GameObject.Find("Button-1 (6)");

        GOption = OG.GetComponent<JiMu5>();
        GameObject OH = GameObject.Find("Button-1 (7)");

        HOption = OH.GetComponent<JiMu5>();

        GameObject OI = GameObject.Find("Button-1 (8)");

        IOption = OI.GetComponent<JiMu5>();

        GameObject OJ = GameObject.Find("Button-1 (9)");

        JOption = OJ.GetComponent<JiMu5>();
        GameObject OK = GameObject.Find("Button-1 (10)");

        KOption = OK.GetComponent<JiMu5>();
        GameObject OL = GameObject.Find("Button-1 (11)");

        LOption = OL.GetComponent<JiMu5>();
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
        // 切换选择状态
        isChoose = !isChoose;
        
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
            COption.isChoose == false &&
            DOption.isChoose == false &&
            EOption.isChoose == true &&
            FOption.isChoose == false &&
            GOption.isChoose == false &&
            HOption.isChoose == false &&
            IOption.isChoose == false &&
            JOption.isChoose == false &&
            KOption.isChoose == false &&
            LOption.isChoose == false)

        {
            Debug.Log("答对啦!");
            EOption.correct = 1;
            TG2Instance.instance.MCorrect2 = EOption.correct;
            SceneManager.LoadScene("JiMu6");
        }
        else
        {
            Debug.Log("答错啦!");

            timeJG5.ReduceTime(10f);

            AOption.wrong += 1;


        }
    }
}
