using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pintu1 : MonoBehaviour
{
    private bool isChoose = false;
    private pintu1 AOption; // 00选项的脚本引用
    private pintu1 BOption; // 01选项的脚本引用
    private pintu1 COption; // 10选项的脚本引用
    private pintu1 DOption; // 11选项的脚本引用

    public Image targetImage1; // 添加对目标Image的引用
    public Image targetImage2; // 添加对目标Image的引用

    public float correct;
    public float wrong;
    public TimePG1 timePG1;
    private void Start()
    {

        // 获得选项的脚本引用
        GameObject OA = GameObject.Find("Button-1");
        AOption = OA.GetComponent<pintu1>();

        GameObject OB = GameObject.Find("Button-2");
        BOption = OB.GetComponent<pintu1>();

        GameObject OC = GameObject.Find("Button-3");
        COption = OC.GetComponent<pintu1>();

        GameObject OD = GameObject.Find("Button-4");
        DOption = OD.GetComponent<pintu1>();
        // 获得选项的脚本引用
        //Debug.Log("已经引用四个选项脚本");
    }
    public void OnButtonClickB()
    {

        // 切换选择状态
        isChoose = !isChoose;
        // 检查答案
        CheckAnswer();
        // 修改Image颜色
        if (targetImage1 != null)
        {
            targetImage2.color = Color.green; // 将颜色设置为绿色
        }
    }
    public void OnButtonClickA()
    {

        // 切换选择状态
        isChoose = !isChoose;
        // 检查答案
        CheckAnswer();
        // 修改Image颜色
        if (targetImage1 != null)
        {
            targetImage1.color = Color.green; // 将颜色设置为绿色
        }
    }

    public void OnButtonClickC()
    {


        // 检查答案
        CheckAnswer();

        timePG1.ReduceTime(10f);
        DOption.wrong += 1;
        isChoose = false;
        // 检查答案
    }
    public void OnButtonClickD()
    {
        timePG1.ReduceTime(10f);
        DOption.wrong += 1;
        isChoose = false;
        // 检查答案
        CheckAnswer();
        // 修改Image颜色


    }
    private void CheckAnswer()
    {
        //Debug.Log("正在调用答案检查器");
        pintu1 CorrectOption1 = AOption;
        pintu1 CorrectOption2 = COption;

        pintu1 WrongOption1 = BOption;
        pintu1 WrongOption2 = DOption;

        if (CorrectOption1.isChoose == true &&
            CorrectOption2.isChoose == true &&
            WrongOption1.isChoose == false &&
            WrongOption2.isChoose == false)
        {
            Debug.Log("答对啦!");
            AOption.correct = 1;
            SceneManager.LoadScene("pintu2");
        }
        else
        {
            Debug.Log("答错啦!");

        }
    }
}