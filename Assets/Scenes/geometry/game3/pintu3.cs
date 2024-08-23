using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pintu3 : MonoBehaviour
{
    private bool isChoose = false;
    private pintu3 AOption; // 00选项的脚本引用
    private pintu3 BOption; // 01选项的脚本引用
    private pintu3 COption; // 10选项的脚本引用
    private pintu3 DOption; // 11选项的脚本引用

    public Image targetImage1; // 添加对目标Image的引用
    public Image targetImage2; // 添加对目标Image的引用

    public float correct;
    public float wrong;
    public TimePG3 timePG3;
    private void Start()
    {

        // 获得选项的脚本引用
        GameObject OA = GameObject.Find("Button-1");
        AOption = OA.GetComponent<pintu3>();

        GameObject OB = GameObject.Find("Button-2");
        BOption = OB.GetComponent<pintu3>();

        GameObject OC = GameObject.Find("Button-3");
        COption = OC.GetComponent<pintu3>();

        GameObject OD = GameObject.Find("Button-4");
        DOption = OD.GetComponent<pintu3>();
        // 获得选项的脚本引用
        //Debug.Log("已经引用四个选项脚本");
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
    public void OnButtonClickC()
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

    public void OnButtonClickA()
    {


        // 检查答案
        CheckAnswer();

        timePG3.ReduceTime(10f);

        isChoose = false;
        // 检查答案
    }
    public void OnButtonClickB()
    {
        timePG3.ReduceTime(10f);

        isChoose = false;
        // 检查答案
        CheckAnswer();
        // 修改Image颜色


    }
    private void CheckAnswer()
    {
        //Debug.Log("正在调用答案检查器");
        pintu3 CorrectOption1 = COption;
        pintu3 CorrectOption2 = DOption;

        pintu3 WrongOption1 = AOption;
        pintu3 WrongOption2 = BOption;

        if (CorrectOption1.isChoose == true &&
            CorrectOption2.isChoose == true &&
            WrongOption1.isChoose == false &&
            WrongOption2.isChoose == false)
        {
            Debug.Log("答对啦!");
            COption.correct = 1;
            SceneManager.LoadScene("pintu4");
        }
        else
        {
            Debug.Log("答错啦!");


            AOption.wrong += 1;


        }
    }
}