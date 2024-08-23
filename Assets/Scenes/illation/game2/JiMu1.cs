using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JiMu1 : MonoBehaviour
{
    private bool isChoose = false;
    public TimeJG1 timeJG1; // 倒计时管理器的引用
    private JiMu1 AOption; // 00选项的脚本引用
    private JiMu1 BOption; // 01选项的脚本引用
    private JiMu1 COption; // 10选项的脚本引用
    private JiMu1 DOption; // 00选项的脚本引用
    private JiMu1 EOption; // 01选项的脚本引用
    private JiMu1 FOption; // 10选项的脚本引用
    private JiMu1 GOption; // 00选项的脚本引用
    private JiMu1 HOption; // 01选项的脚本引用
    private JiMu1 IOption; // 10选项的脚本引用
    private JiMu1 JOption; // 00选项的脚本引用
    private JiMu1 KOption; // 01选项的脚本引用
    private JiMu1 LOption; // 10选项的脚本引用

    public float correct = 0;
    public float wrong = 0;
    private JiMu1 CorrectAnswer;
    private JiMu1 WrongAnswer1;
    private JiMu1 WrongAnswer2;
    private JiMu1 WrongAnswer3;
    private JiMu1 WrongAnswer4;
    private JiMu1 WrongAnswer5;
    private JiMu1 WrongAnswer6;
    private JiMu1 WrongAnswer7;
    private JiMu1 WrongAnswer8;
    private JiMu1 WrongAnswer9;
    private JiMu1 WrongAnswer10;
    private JiMu1 WrongAnswer11;
    private JiMu1 WrongAnswer12;
    private void Start()
    {
        //Debug.Log("正在调用答案检查器");

        // 获取当前Button的Image组件


        // 获得选项的脚本引用——
        GameObject OA = GameObject.Find("Button-1");

        AOption = OA.GetComponent<JiMu1>();

        GameObject OB = GameObject.Find("Button-1 (1)");

        BOption = OB.GetComponent<JiMu1>();

        GameObject OC = GameObject.Find("Button-1 (2)");

        COption = OC.GetComponent<JiMu1>();
        GameObject OD = GameObject.Find("Button-1 (3)");

        DOption = OD.GetComponent<JiMu1>();
        GameObject OE = GameObject.Find("Button-1 (4)");

        EOption = OE.GetComponent<JiMu1>();

        GameObject OF = GameObject.Find("Button-1 (5)");

        FOption = OF.GetComponent<JiMu1>();

        GameObject OG = GameObject.Find("Button-1 (6)");

        GOption = OG.GetComponent<JiMu1>();
        GameObject OH = GameObject.Find("Button-1 (7)");

        HOption = OH.GetComponent<JiMu1>();

        GameObject OI = GameObject.Find("Button-1 (8)");

        IOption = OI.GetComponent<JiMu1>();

        GameObject OJ = GameObject.Find("Button-1 (9)");

        JOption = OJ.GetComponent<JiMu1>();
        GameObject OK = GameObject.Find("Button-1 (10)");

        KOption = OK.GetComponent<JiMu1>();
        GameObject OL = GameObject.Find("Button-1 (11)");

        LOption = OL.GetComponent<JiMu1>();
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
            TG2Instance.instance.JCorrect1 = COption.correct;
            SceneManager.LoadScene("JiMu2");
        }
        else
        {
            Debug.Log("答错啦!");

            timeJG1.ReduceTime(10f);

            AOption.wrong += 1;
        }
    }
}
