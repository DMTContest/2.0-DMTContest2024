using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Tuxing1 : MonoBehaviour
{
    private bool isChoose = false;
    private Tuxing1 AOption; // 00选项的脚本引用
    private Tuxing1 BOption; // 01选项的脚本引用
    private Tuxing1 COption; // 10选项的脚本引用
    private Tuxing1 DOption; // 10选项的脚本引用

    public float correct = 0;
    public float wrong = 0;

    public TimeTX1 timeTX1; // 倒计时管理器的引用
    public float timeStart;


    private Tuxing1 CorrectAnswer;
    private Tuxing1 WrongAnswer1;
    private Tuxing1 WrongAnswer2;
    private Tuxing1 WrongAnswer3;

    private void Start()
    {

        //Debug.Log("正在调用答案检查器");

        // 获取当前Button的Image组件


        // 获得选项的脚本引用——
        GameObject OA = GameObject.Find("BtnA");

        AOption = OA.GetComponent<Tuxing1>();

        GameObject OB = GameObject.Find("BtnB");

        BOption = OB.GetComponent<Tuxing1>();

        GameObject OC = GameObject.Find("BtnC");

        COption = OC.GetComponent<Tuxing1>();
        GameObject OD = GameObject.Find("BtnD");

        DOption = OD.GetComponent<Tuxing1>();


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
        // 切换选择状态
        isChoose = !isChoose;
      
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

        if (AOption.isChoose == false &&
             BOption.isChoose == true &&
             COption.isChoose == false &&
             DOption.isChoose == false)
        {
            Debug.Log("答对啦!");
            BOption.correct = 1;
            GG1Instance.instance.JCorrect1 = BOption.correct;
            SceneManager.LoadScene("TuXing2");
        }
        else
        {
            Debug.Log("答错啦!");

            timeTX1.ReduceTime(10f);

            AOption.wrong += 1;


        }
    }
}