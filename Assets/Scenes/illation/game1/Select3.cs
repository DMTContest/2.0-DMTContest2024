using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Select3 : MonoBehaviour
{
    private bool isChoose = false;
    public TimeIG3 timeIG3; // 倒计时管理器的引用
    private Select3 AOption; // 00选项的脚本引用
    private Select3 BOption; // 01选项的脚本引用
    private Select3 COption; // 10选项的脚本引用

    public Button buttonA;
    public Button buttonB;
    public Button buttonC;

    public float correct = 0;
    public float wrong = 0;

    private Select3 CorrectAnswer;
    private Select3 WrongAnswer1;
    private Select3 WrongAnswer2;

    private void Start()
    {
        //Debug.Log("正在调用答案检查器");

        // 获取当前Button的Image组件


        // 获得选项的脚本引用——
        GameObject OA = GameObject.Find("Button-1");

        AOption = OA.GetComponent<Select3>();

        GameObject OB = GameObject.Find("Button-2");

        BOption = OB.GetComponent<Select3>();

        GameObject OC = GameObject.Find("Button-3");


        COption = OC.GetComponent<Select3>();
        //Debug.Log("已经引用3个选项脚本");


    }

    //Debug.Log("已经引用3个选项脚本");

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


    private void CheckAnswer()
    {


        if (AOption.isChoose == false &&
            BOption.isChoose == true &&
            COption.isChoose == false)
        {
            Debug.Log("答对啦!");
            BOption.correct = 1;
            TG1Instance.instance.JCorrect3 = BOption.correct;
            SceneManager.LoadScene("Select4");
        }
        else
        {
            Debug.Log("答错啦!");

            timeIG3.ReduceTime(10f);

            AOption.wrong += 1;


        }
    }
}