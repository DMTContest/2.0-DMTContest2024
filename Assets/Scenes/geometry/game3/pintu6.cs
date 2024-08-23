using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pintu6 : MonoBehaviour
{
    private bool isChoose = false;
    private pintu6 AOption; // 00选项的脚本引用
    private pintu6 BOption; // 01选项的脚本引用
    private pintu6 COption; // 10选项的脚本引用
    private pintu6 DOption; // 11选项的脚本引用
    private pintu6 EOption; // 00选项的脚本引用
    private pintu6 FOption; // 01选项的脚本引用
    private pintu6 GOption; // 10选项的脚本引用
    private pintu6 HOption; // 11选项的脚本引用
    public Image targetImage1; // 添加对目标Image的引用
    public Image targetImage2; // 添加对目标Image的引用
    public Image targetImage3; // 添加对目标Image的引用
    public Image targetImage4; // 添加对目标Image的引用

    public float correct;
    public float wrong;
    public TimePG6 timePG6;
    private void Start()
    {

        // 获得选项的脚本引用
        GameObject OA = GameObject.Find("Button-1");
        AOption = OA.GetComponent<pintu6>();

        GameObject OB = GameObject.Find("Button-2");
        BOption = OB.GetComponent<pintu6>();

        GameObject OC = GameObject.Find("Button-3");
        COption = OC.GetComponent<pintu6>();

        GameObject OD = GameObject.Find("Button-4");
        DOption = OD.GetComponent<pintu6>();
        // 获得选项的脚本引用
        GameObject OE = GameObject.Find("Button-5");
        EOption = OE.GetComponent<pintu6>();

        GameObject OF = GameObject.Find("Button-6");
        FOption = OF.GetComponent<pintu6>();

        GameObject OG = GameObject.Find("Button-7");
        GOption = OG.GetComponent<pintu6>();

        GameObject OH = GameObject.Find("Button-8");
        HOption = OH.GetComponent<pintu6>();
    }
    public void OnButtonClickB()
    {
        isChoose = false;
        // 检查答案
        CheckAnswer();
        timePG6.ReduceTime(10f);

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
    public void OnButtonClickD()
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
    public void OnButtonClickE()
    {

        isChoose = false;
        // 检查答案
        CheckAnswer();
        timePG6.ReduceTime(10f);



    }

    public void OnButtonClickF()
    {

        // 切换选择状态
        isChoose = !isChoose;
        // 检查答案
        CheckAnswer();
        // 修改Image颜色
        if (targetImage4 != null)
        {
            targetImage4.color = Color.green; // 将颜色设置为绿色
        }
    }
    public void OnButtonClickG()
    {
        timePG6.ReduceTime(10f);

        isChoose = false;
        // 检查答案
        CheckAnswer();
        // 修改Image颜色

    }
    public void OnButtonClickH()
    {
        timePG6.ReduceTime(10f);

        isChoose = false;
        // 检查答案
        CheckAnswer();
        // 修改Image颜色


    }
    private void CheckAnswer()
    {
        //Debug.Log("正在调用答案检查器");
        pintu6 CorrectOption1 = AOption;
        pintu6 CorrectOption2 = COption;
        pintu6 CorrectOption3 = DOption;
        pintu6 CorrectOption4 = FOption;


        pintu6 WrongOption1 = BOption;
        pintu6 WrongOption2 = EOption;
        pintu6 WrongOption3 = GOption;
        pintu6 WrongOption4 = HOption;

        if (CorrectOption1.isChoose == true &&
            CorrectOption2.isChoose == true &&
            CorrectOption3.isChoose == true &&
            CorrectOption4.isChoose == true &&
            WrongOption3.isChoose == false &&
            WrongOption1.isChoose == false &&
            WrongOption4.isChoose == false &&
            WrongOption2.isChoose == false)
        {
            Debug.Log("答对啦!");
            AOption.correct = 1;
            SceneManager.LoadScene("pintu7");
        }
        else
        {
            Debug.Log("答错啦!");


            BOption.wrong += 1;


        }
    }
}