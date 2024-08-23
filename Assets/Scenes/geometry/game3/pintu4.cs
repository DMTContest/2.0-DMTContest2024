using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pintu4 : MonoBehaviour
{
    private bool isChoose = false;
    private pintu4 AOption; // 00选项的脚本引用
    private pintu4 BOption; // 01选项的脚本引用
    private pintu4 COption; // 10选项的脚本引用
    private pintu4 DOption; // 11选项的脚本引用

    public Image targetImage1; // 添加对目标Image的引用
    public Image targetImage2; // 添加对目标Image的引用

    public float correct;
    public float wrong;
    public TimePG4 timePG4;
    private void Start()
    {

        // 获得选项的脚本引用
        GameObject OA = GameObject.Find("Button-1");
        AOption = OA.GetComponent<pintu4>();

        GameObject OB = GameObject.Find("Button-2");
        BOption = OB.GetComponent<pintu4>();

        GameObject OC = GameObject.Find("Button-3");
        COption = OC.GetComponent<pintu4>();

        GameObject OD = GameObject.Find("Button-4");
        DOption = OD.GetComponent<pintu4>();
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
        if (targetImage2 != null)
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


        COption.wrong += 1;
        // 检查答案
        CheckAnswer();

        timePG4.ReduceTime(10f);

        isChoose = false;
        // 检查答案
    }
    public void OnButtonClickD()
    {
        timePG4.ReduceTime(10f);

        isChoose = false;
        // 检查答案
        CheckAnswer();
        // 修改Image颜色

        COption.wrong += 1;


    }
    private void CheckAnswer()
    {
        //Debug.Log("正在调用答案检查器");
        pintu4 CorrectOption1 = AOption;
        pintu4 CorrectOption2 = BOption;

        pintu4 WrongOption1 = COption;
        pintu4 WrongOption2 = DOption;

        if (CorrectOption1.isChoose == true &&
            CorrectOption2.isChoose == true &&
            WrongOption1.isChoose == false &&
            WrongOption2.isChoose == false)
        {
            Debug.Log("答对啦!");
            AOption.correct = 1;
            SceneManager.LoadScene("pintu5");
        }
        else
        {
            Debug.Log("答错啦!");




        }
    }
}