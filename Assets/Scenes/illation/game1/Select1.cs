using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Select1 : MonoBehaviour
{
    private bool isChoose = false;
    private Select1 AOption; // 00选项的脚本引用
    private Select1 BOption; // 01选项的脚本引用
    private Select1 COption; // 10选项的脚本引用

    public float correct = 0;
    public float wrong = 0;

    public TimeIG1 timeIG11; // 倒计时管理器的引用

    public Button buttonA;
    public Button buttonB;
    public Button buttonC;
    public float timeStart;

    
    private Select1 CorrectAnswer;
    private Select1 WrongAnswer1;
    private Select1 WrongAnswer2;
  
    private void Start()
    {
      
        //Debug.Log("正在调用答案检查器");

        // 获取当前Button的Image组件


        // 获得选项的脚本引用——
        GameObject OA = GameObject.Find("Button-1");

        AOption = OA.GetComponent<Select1>();

        GameObject OB = GameObject.Find("Button-2");

        BOption = OB.GetComponent<Select1>();

        GameObject OC = GameObject.Find("Button-3");

        COption = OC.GetComponent<Select1>();



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
             COption.isChoose ==true)
        {
            Debug.Log("答对啦!");
            COption.correct = 1;
            TG1Instance.instance.JCorrect1 = COption.correct;
            SceneManager.LoadScene("Select2");
        }
        else
        {
            Debug.Log("答错啦!");

            timeIG11.ReduceTime(10f);

            BOption.wrong += 1;


        }
    }
}