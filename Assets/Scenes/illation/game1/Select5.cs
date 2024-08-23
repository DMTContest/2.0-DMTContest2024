using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Select5 : MonoBehaviour
{
    private bool isChoose = false;
    private Select5 AOption; // 00选项的脚本引用
    private Select5 BOption; // 01选项的脚本引用
    private Select5 COption; // 10选项的脚本引用

    public float correct = 0;
    public float wrong = 0;

    public TimeIG5 timeIG5; // 倒计时管理器的引用

    public Button buttonA;
    public Button buttonB;
    public Button buttonC;
    public float timeStart;


    private Select5 CorrectAnswer;
    private Select5 WrongAnswer1;
    private Select5 WrongAnswer2;

    private void Start()
    {

        //Debug.Log("正在调用答案检查器");

        // 获取当前Button的Image组件


        // 获得选项的脚本引用——
        GameObject OA = GameObject.Find("Button-1");

        AOption = OA.GetComponent<Select5>();

        GameObject OB = GameObject.Find("Button-2");

        BOption = OB.GetComponent<Select5>();

        GameObject OC = GameObject.Find("Button-3");


        COption = OC.GetComponent<Select5>();



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


    private void CheckAnswer()
    {


        if (AOption.isChoose == true &&
            BOption.isChoose == false &&
            COption.isChoose == false)
        {
            Debug.Log("答对啦!");
            AOption.correct = 1;
            TG1Instance.instance.MCorrect2 = AOption.correct;
            SceneManager.LoadScene("Select6");
        }
        else
        {
            Debug.Log("答错啦!");

            timeIG5.ReduceTime(10f);

            BOption.wrong += 1;


        }
    }
}