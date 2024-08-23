using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TuXing2 : MonoBehaviour
{
    private bool isChoose = false;
    private TuXing2 AOption; // 00选项的脚本引用
    private TuXing2 BOption; // 01选项的脚本引用
    private TuXing2 COption; // 10选项的脚本引用
    private TuXing2 DOption; // 10选项的脚本引用

    public float correct = 0;
    public float wrong = 0;

    public TimeTX2 timeTX2; // 倒计时管理器的引用
    public float timeStart;


    private TuXing2 CorrectAnswer;
    private TuXing2 WrongAnswer1;
    private TuXing2 WrongAnswer2;
    private TuXing2 WrongAnswer3;

    private void Start()
    {

        //Debug.Log("正在调用答案检查器");

        // 获取当前Button的Image组件


        // 获得选项的脚本引用——
        GameObject OA = GameObject.Find("BtnA");

        AOption = OA.GetComponent<TuXing2>();

        GameObject OB = GameObject.Find("BtnB");

        BOption = OB.GetComponent<TuXing2>();

        GameObject OC = GameObject.Find("BtnC");

        COption = OC.GetComponent<TuXing2>();
        GameObject OD = GameObject.Find("BtnD");

        DOption = OD.GetComponent<TuXing2>();


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
        isChoose = false;
        // 检查答案
        CheckAnswer();
    }
    public void OnButtonClickD()
    {
        // 切换选择状态
        isChoose = !isChoose;
        // 检查答案
        CheckAnswer();
    }
    private void CheckAnswer()
    {

        if (AOption.isChoose == false &&
             BOption.isChoose == false &&
             COption.isChoose == false &&
             DOption.isChoose == true)
        {
            Debug.Log("答对啦!");
            DOption.correct = 1;
            GG1Instance.instance.JCorrect2 = DOption.correct;
            SceneManager.LoadScene("TuXing3");
        }
        else
        {
            Debug.Log("答错啦!");

            timeTX2.ReduceTime(10f);

            AOption.wrong += 1;


        }
    }
}