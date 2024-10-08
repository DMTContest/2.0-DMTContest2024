using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pintu7 : MonoBehaviour
{
    private bool isChoose = false;
    private pintu7 AOption; // 00选项的脚本引用
    private pintu7 BOption; // 01选项的脚本引用
    private pintu7 COption; // 10选项的脚本引用
    private pintu7 DOption; // 11选项的脚本引用
    private pintu7 EOption; // 00选项的脚本引用
    private pintu7 FOption; // 01选项的脚本引用
    private pintu7 GOption; // 10选项的脚本引用
    private pintu7 HOption; // 11选项的脚本引用
    public Image targetImage1; // 添加对目标Image的引用
    public Image targetImage2; // 添加对目标Image的引用
    public Image targetImage3; // 添加对目标Image的引用


    public float correct;
    public float wrong;
    public TimePG7 timePG7;
    private void Start()
    {

        // 获得选项的脚本引用
        GameObject OA = GameObject.Find("Button-1");
        AOption = OA.GetComponent<pintu7>();

        GameObject OB = GameObject.Find("Button-2");
        BOption = OB.GetComponent<pintu7>();

        GameObject OC = GameObject.Find("Button-3");
        COption = OC.GetComponent<pintu7>();

        GameObject OD = GameObject.Find("Button-4");
        DOption = OD.GetComponent<pintu7>();
        // 获得选项的脚本引用
        GameObject OE = GameObject.Find("Button-5");
        EOption = OE.GetComponent<pintu7>();

        GameObject OF = GameObject.Find("Button-6");
        FOption = OF.GetComponent<pintu7>();

        GameObject OG = GameObject.Find("Button-7");
        GOption = OG.GetComponent<pintu7>();

        GameObject OH = GameObject.Find("Button-8");
        HOption = OH.GetComponent<pintu7>();
        //Debug.Log("已经引用四个选项脚本");
    }
    public void OnButtonClickB()
    {
        isChoose = false;
        // 检查答案
        CheckAnswer();
        timePG7.ReduceTime(10f);

        BOption.wrong += 1;

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
        isChoose = false;
        // 检查答案
        CheckAnswer();

        BOption.wrong += 1;
        timePG7.ReduceTime(10f);
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
    public void OnButtonClickE()
    {

        isChoose = false;
        // 检查答案
        CheckAnswer();
        timePG7.ReduceTime(10f);

        BOption.wrong += 1;

    }

    public void OnButtonClickF()
    {
        isChoose = false;
        // 检查答案
        CheckAnswer();

        BOption.wrong += 1;
        timePG7.ReduceTime(10f);
    }
    public void OnButtonClickG()
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
    public void OnButtonClickH()
    {
        timePG7.ReduceTime(10f);

        isChoose = false;
        // 检查答案
        CheckAnswer();
        // 修改Image颜色

        BOption.wrong += 1;


    }
    private void CheckAnswer()
    {
        //Debug.Log("正在调用答案检查器");
        pintu7 CorrectOption1 = AOption;
        pintu7 CorrectOption2 = DOption;
        pintu7 CorrectOption3 = GOption;


        pintu7 WrongOption1 = BOption;
        pintu7 WrongOption2 = COption;
        pintu7 WrongOption3 = EOption;
        pintu7 WrongOption4 = FOption;
        pintu7 WrongOption5 = HOption;
        Debug.Log($"AOption.isChoose: {AOption.isChoose}");
        Debug.Log($"BOption.isChoose: {BOption.isChoose}");
        Debug.Log($"COption.isChoose: {COption.isChoose}");
        Debug.Log($"DOption.isChoose: {DOption.isChoose}");
        Debug.Log($"EOption.isChoose: {EOption.isChoose}");
        Debug.Log($"FOption.isChoose: {FOption.isChoose}");
        Debug.Log($"GOption.isChoose: {GOption.isChoose}");
        Debug.Log($"HOption.isChoose: {HOption.isChoose}");
        if (CorrectOption1.isChoose == true &&
            CorrectOption2.isChoose == true &&
            CorrectOption3.isChoose == true &&
            WrongOption1.isChoose == false &&
            WrongOption2.isChoose == false &&
            WrongOption3.isChoose == false &&
            WrongOption4.isChoose == false &&
            WrongOption5.isChoose == false)
        {
            Debug.Log("答对啦!");
            AOption.correct = 1;
            SceneManager.LoadScene("pintu8");
        }
        else
        {
            Debug.Log("答错啦!");

        }
    }
}