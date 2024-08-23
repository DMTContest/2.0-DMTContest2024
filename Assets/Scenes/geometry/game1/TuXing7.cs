using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TuXing7 : MonoBehaviour
{
    private bool isChoose = false;
    private TuXing7 AOption; // 00选项的脚本引用
    private TuXing7 BOption; // 01选项的脚本引用
    private TuXing7 COption; // 10选项的脚本引用
    private TuXing7 DOption; // 10选项的脚本引用

    public float correct = 0;
    public float wrong = 0;

    public TimeTX7 timeTX7; // 倒计时管理器的引用
    public float timeStart;


    private TuXing7 CorrectAnswer;
    private TuXing7 WrongAnswer1;
    private TuXing7 WrongAnswer2;
    private TuXing7 WrongAnswer3;

    private void Start()
    {

        //Debug.Log("正在调用答案检查器");

        // 获取当前Button的Image组件


        // 获得选项的脚本引用——
        GameObject OA = GameObject.Find("BtnA");

        AOption = OA.GetComponent<TuXing7>();

        GameObject OB = GameObject.Find("BtnB");

        BOption = OB.GetComponent<TuXing7>();

        GameObject OC = GameObject.Find("BtnC");

        COption = OC.GetComponent<TuXing7>();
        GameObject OD = GameObject.Find("BtnD");

        DOption = OD.GetComponent<TuXing7>();


        //Debug.Log("已经引用3个选项脚本");
    }

    public void OnButtonClickA()
    {
        // 切换选择状态
        isChoose = !isChoose;
       
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
    private void CheckAnswer()
    {

        if (AOption.isChoose == true &&
             BOption.isChoose == false &&
             COption.isChoose == false &&
             DOption.isChoose == false)
        {
            Debug.Log("答对啦!");
            AOption.correct = 1;
            GG1Instance.instance.HCorrect1 = AOption.correct;
            SceneManager.LoadScene("TuXing8");
        }
        else
        {
            Debug.Log("答错啦!");

            timeTX7.ReduceTime(10f);

            BOption.wrong += 1;


        }
    }
}