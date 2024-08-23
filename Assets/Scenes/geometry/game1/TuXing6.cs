using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TuXing6 : MonoBehaviour
{
    private bool isChoose = false;
    private TuXing6 AOption; // 00选项的脚本引用
    private TuXing6 BOption; // 01选项的脚本引用
    private TuXing6 COption; // 10选项的脚本引用
    private TuXing6 DOption; // 10选项的脚本引用

    public float correct = 0;
    public float wrong = 0;

    public TimeTX6 timeTX6; // 倒计时管理器的引用
    public float timeStart;


    private TuXing6 CorrectAnswer;
    private TuXing6 WrongAnswer1;
    private TuXing6 WrongAnswer2;
    private TuXing6 WrongAnswer3;

    private void Start()
    {

        //Debug.Log("正在调用答案检查器");

        // 获取当前Button的Image组件


        // 获得选项的脚本引用——
        GameObject OA = GameObject.Find("BtnA");

        AOption = OA.GetComponent<TuXing6>();

        GameObject OB = GameObject.Find("BtnB");

        BOption = OB.GetComponent<TuXing6>();

        GameObject OC = GameObject.Find("BtnC");

        COption = OC.GetComponent<TuXing6>();
        GameObject OD = GameObject.Find("BtnD");

        DOption = OD.GetComponent<TuXing6>();


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
            GG1Instance.instance.MCorrect3 = DOption.correct;
            SceneManager.LoadScene("TuXing7");
        }
        else
        {
            Debug.Log("答错啦!");

            timeTX6.ReduceTime(10f);

            AOption.wrong += 1;


        }
    }
}