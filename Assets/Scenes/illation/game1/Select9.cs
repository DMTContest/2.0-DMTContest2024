using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Select9 : MonoBehaviour
{
    private bool isChoose = false;
    private Select9 AOption; // 00选项的脚本引用
    private Select9 BOption; // 01选项的脚本引用
    private Select9 COption; // 10选项的脚本引用

    public float correct = 0;
    public float wrong = 0;

    public TimeIG9 timeIG9; // 倒计时管理器的引用

    public Button buttonA;
    public Button buttonB;
    public Button buttonC;
    public float timeStart;


    private Select9 CorrectAnswer;
    private Select9 WrongAnswer1;
    private Select9 WrongAnswer2;

    private void Start()
    {

        //Debug.Log("正在调用答案检查器");

        // 获取当前Button的Image组件


        // 获得选项的脚本引用——
        GameObject OA = GameObject.Find("Button-1");

        AOption = OA.GetComponent<Select9>();

        GameObject OB = GameObject.Find("Button-2");

        BOption = OB.GetComponent<Select9>();

        GameObject OC = GameObject.Find("Button-3");

        COption = OC.GetComponent<Select9>();



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
    private void CheckAnswer()
    {


        if (AOption.isChoose == false &&
             BOption.isChoose == false &&
             COption.isChoose == true)
        {
            Debug.Log("答对啦!");
            COption.correct = 1;
            TG1Instance.instance.HCorrect3 = COption.correct;
            SceneManager.LoadScene("Select10");
        }
        else
        {
            Debug.Log("答错啦!");

            timeIG9.ReduceTime(10f);

            BOption.wrong += 1;


        }
    }
}