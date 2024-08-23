using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pintu2 : MonoBehaviour
{
    private bool isChoose = false;
    private pintu2 AOption; // 00选项的脚本引用
    private pintu2 BOption; // 01选项的脚本引用
    private pintu2 COption; // 10选项的脚本引用
    private pintu2 DOption; // 11选项的脚本引用

    public Image targetImage1; // 添加对目标Image的引用
    public Image targetImage2; // 添加对目标Image的引用

    public float correct;
    public float wrong;
    public TimePG2 timePG2;
    private void Start()
    {

        // 获得选项的脚本引用
        GameObject OA = GameObject.Find("Button-1");
        AOption = OA.GetComponent<pintu2>();

        GameObject OB = GameObject.Find("Button-2");
        BOption = OB.GetComponent<pintu2>();

        GameObject OC = GameObject.Find("Button-3");
        COption = OC.GetComponent<pintu2>();

        GameObject OD = GameObject.Find("Button-4");
        DOption = OD.GetComponent<pintu2>();
        // 获得选项的脚本引用
        //Debug.Log("已经引用四个选项脚本");
    }
    public void OnButtonClickB()
    {

        // 切换选择状态
        isChoose = !isChoose;
        // 修改Image颜色
        if (targetImage1 != null)
        {
            targetImage1.color = Color.green; // 将颜色设置为绿色
        }
        // 检查答案
        CheckAnswer();
    }
    public void OnButtonClickA()
    {
        // 检查答案
        CheckAnswer();

        timePG2.ReduceTime(10f);

        isChoose = false;
        // 检查答案

    }

    public void OnButtonClickC()
    {

        // 检查答案
        CheckAnswer();

        timePG2.ReduceTime(10f);

        isChoose = false;
        // 检查答案

    }
    public void OnButtonClickD()
    {
        // 切换选择状态
        isChoose = !isChoose;
        // 检查答案
        CheckAnswer();
        // 修改Image颜色
        if (targetImage2 != null)
        {
            targetImage2.color = Color.green; // 将颜色设置为绿色
        }

    }
    private void CheckAnswer()
    {
        //Debug.Log("正在调用答案检查器");
        pintu2 CorrectOption1 = BOption;
        pintu2 CorrectOption2 = DOption;

        pintu2 WrongOption1 = AOption;
        pintu2 WrongOption2 = COption;

        if (CorrectOption1.isChoose == true &&
            CorrectOption2.isChoose == true &&
            WrongOption1.isChoose == false &&
            WrongOption2.isChoose == false)
        {
            Debug.Log("答对啦!");
            BOption.correct = 1;
            SceneManager.LoadScene("pintu3");
        }
        else
        {
            Debug.Log("答错啦!");


            COption.wrong += 1;


        }
    }
}