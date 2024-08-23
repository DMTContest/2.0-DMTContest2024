using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TuXing10 : MonoBehaviour
{
    private bool isChoose = false;
    private TuXing10 AOption; // 00选项的脚本引用
    private TuXing10 BOption; // 01选项的脚本引用
    private TuXing10 COption; // 10选项的脚本引用
    private TuXing10 DOption; // 10选项的脚本引用

    public float correct = 0;
    public float wrong = 0;

    public TimeTX10 timeTX10; // 倒计时管理器的引用
    public float timeStart;


    private TuXing10 CorrectAnswer;
    private TuXing10 WrongAnswer1;
    private TuXing10 WrongAnswer2;
    private TuXing10 WrongAnswer3;

    private void Start()
    {

        //Debug.Log("正在调用答案检查器");

        // 获取当前Button的Image组件


        // 获得选项的脚本引用——
        GameObject OA = GameObject.Find("BtnA");

        AOption = OA.GetComponent<TuXing10>();

        GameObject OB = GameObject.Find("BtnB");

        BOption = OB.GetComponent<TuXing10>();

        GameObject OC = GameObject.Find("BtnC");

        COption = OC.GetComponent<TuXing10>();
        GameObject OD = GameObject.Find("BtnD");

        DOption = OD.GetComponent<TuXing10>();


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
    private void CheckAnswer()
    {

        if (AOption.isChoose == false &&
             BOption.isChoose == false &&
             COption.isChoose == true &&
             DOption.isChoose == false)
        {
            Debug.Log("答对啦!");
            COption.correct = 1;
            GG1Instance.instance.HCorrect4 = COption.correct;
            SceneManager.LoadScene("XGFinal");
        }
        else
        {
            Debug.Log("答错啦!");

            timeTX10.ReduceTime(10f);

            AOption.wrong += 1;


        }
    }
}