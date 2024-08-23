using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Select2 : MonoBehaviour
{
    private bool isChoose = false;
    private Select2 AOption; // 00选项的脚本引用
    private Select2 BOption; // 01选项的脚本引用
    private Select2 COption; // 10选项的脚本引用

    public float correct = 0;
    public float wrong = 0;

    public TimeIG2 timeIG2; // 倒计时管理器的引用

    public Button buttonA;
    public Button buttonB;
    public Button buttonC;
    public float timeStart;


    private Select2 CorrectAnswer;
    private Select2 WrongAnswer1;
    private Select2 WrongAnswer2;

    private void Start()
    {

        //Debug.Log("正在调用答案检查器");

        // 获取当前Button的Image组件


        // 获得选项的脚本引用——
        GameObject OA = GameObject.Find("Button-1");

        AOption = OA.GetComponent<Select2>();

        GameObject OB = GameObject.Find("Button-2");

        BOption = OB.GetComponent<Select2>();

        GameObject OC = GameObject.Find("Button-3");


        COption = OC.GetComponent<Select2>();



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
            TG1Instance.instance.JCorrect2 = AOption.correct;
            SceneManager.LoadScene("Select3");
        }
        else
        {
            Debug.Log("答错啦!");

            timeIG2.ReduceTime(10f);

            BOption.wrong += 1;


        }
    }
}