using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TuXing8 : MonoBehaviour
{
    private bool isChoose = false;
    private TuXing8 AOption; // 00选项的脚本引用
    private TuXing8 BOption; // 01选项的脚本引用
    private TuXing8 COption; // 10选项的脚本引用
    private TuXing8 DOption; // 10选项的脚本引用

    public float correct = 0;
    public float wrong = 0;

    public TimeTX8 timeTX8; // 倒计时管理器的引用
    public float timeStart;


    private TuXing8 CorrectAnswer;
    private TuXing8 WrongAnswer1;
    private TuXing8 WrongAnswer2;
    private TuXing8 WrongAnswer3;

    private void Start()
    {

        //Debug.Log("正在调用答案检查器");

        // 获取当前Button的Image组件


        // 获得选项的脚本引用——
        GameObject OA = GameObject.Find("BtnA");

        AOption = OA.GetComponent<TuXing8>();

        GameObject OB = GameObject.Find("BtnB");

        BOption = OB.GetComponent<TuXing8>();

        GameObject OC = GameObject.Find("BtnC");

        COption = OC.GetComponent<TuXing8>();
        GameObject OD = GameObject.Find("BtnD");

        DOption = OD.GetComponent<TuXing8>();


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
            GG1Instance.instance.HCorrect2 = AOption.correct;
            SceneManager.LoadScene("TuXing9");
        }
        else
        {
            Debug.Log("答错啦!");

            timeTX8.ReduceTime(10f);

            BOption.wrong += 1;


        }
    }
}