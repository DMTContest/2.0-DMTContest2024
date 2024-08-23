using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pintu9 : MonoBehaviour
{
    private bool isChoose = false;
    private pintu9 AOption; // 00选项的脚本引用
    private pintu9 BOption; // 01选项的脚本引用
    private pintu9 COption; // 10选项的脚本引用
    private pintu9 DOption; // 11选项的脚本引用
    private pintu9 EOption; // 00选项的脚本引用
    private pintu9 FOption; // 01选项的脚本引用
    private pintu9 GOption; // 10选项的脚本引用
    private pintu9 HOption; // 11选项的脚本引用
    public Image targetImage1; // 添加对目标Image的引用
    public Image targetImage2; // 添加对目标Image的引用
    public Image targetImage3; // 添加对目标Image的引用


    public float correct;
    public float wrong;
    public TimePG9 timePG9;
    private void Start()
    {

        // 获得选项的脚本引用
        // 获得选项的脚本引用
        GameObject OA = GameObject.Find("Button-1");
        AOption = OA.GetComponent<pintu9>();

        GameObject OB = GameObject.Find("Button-2");
        BOption = OB.GetComponent<pintu9>();

        GameObject OC = GameObject.Find("Button-3");
        COption = OC.GetComponent<pintu9>();

        GameObject OD = GameObject.Find("Button-4");
        DOption = OD.GetComponent<pintu9>();
        // 获得选项的脚本引用
        GameObject OE = GameObject.Find("Button-5");
        EOption = OE.GetComponent<pintu9>();

        GameObject OF = GameObject.Find("Button-6");
        FOption = OF.GetComponent<pintu9>();

        GameObject OG = GameObject.Find("Button-7");
        GOption = OG.GetComponent<pintu9>();

        GameObject OH = GameObject.Find("Button-8");
        HOption = OH.GetComponent<pintu9>();
        //Debug.Log("已经引用四个选项脚本");
    }
    public void OnButtonClickA()
    {
        isChoose = false;
        // 检查答案
        CheckAnswer();
        timePG9.ReduceTime(10f);

    }
    public void OnButtonClickB()
    {
        isChoose = false;
        // 检查答案
        CheckAnswer();
        timePG9.ReduceTime(10f);

    }

    public void OnButtonClickC()
    {
        isChoose = false;
        // 检查答案
        CheckAnswer();
        timePG9.ReduceTime(10f);

    }
    public void OnButtonClickD()
    {
        isChoose = false;
        // 检查答案
        CheckAnswer();
        timePG9.ReduceTime(10f);

    }
    public void OnButtonClickE()
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

    public void OnButtonClickF()
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
    public void OnButtonClickG()
    {

        isChoose = false;
        // 检查答案
        CheckAnswer();
        timePG9.ReduceTime(10f);
    }
    public void OnButtonClickH()
    {

        // 切换选择状态
        isChoose = !isChoose;
        // 检查答案
        CheckAnswer();
        // 修改Image颜色
        if (targetImage3 != null)
        {
            targetImage3.color = Color.green; // 将颜色设置为绿色
        }

    }
    private void CheckAnswer()
    {
        //Debug.Log("正在调用答案检查器");
        pintu9 CorrectOption1 = EOption;
        pintu9 CorrectOption2 = FOption;
        pintu9 CorrectOption3 = HOption;


        pintu9 WrongOption1 = AOption;
        pintu9 WrongOption2 = BOption;
        pintu9 WrongOption3 = COption;
        pintu9 WrongOption4 = DOption;
        pintu9 WrongOption5 = GOption;

        if (CorrectOption1.isChoose == true &&
            CorrectOption2.isChoose == true &&
            CorrectOption3.isChoose == true &&
            WrongOption3.isChoose == false &&
            WrongOption1.isChoose == false &&
            WrongOption4.isChoose == false &&
            WrongOption5.isChoose == false &&
            WrongOption2.isChoose == false)
        {
            Debug.Log("答对啦!");
            EOption.correct = 1;
            SceneManager.LoadScene("pintu10");
        }
        else
        {
            Debug.Log("答错啦!");


            AOption.wrong += 1;


        }
    }
}