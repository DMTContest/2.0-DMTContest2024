using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pintu8 : MonoBehaviour
{
    private bool isChoose = false;
    private pintu8 AOption; // 00选项的脚本引用
    private pintu8 BOption; // 01选项的脚本引用
    private pintu8 COption; // 10选项的脚本引用
    private pintu8 DOption; // 11选项的脚本引用
    private pintu8 EOption; // 00选项的脚本引用
    private pintu8 FOption; // 01选项的脚本引用
    private pintu8 GOption; // 10选项的脚本引用
    private pintu8 HOption; // 11选项的脚本引用
    public Image targetImage1; // 添加对目标Image的引用
    public Image targetImage2; // 添加对目标Image的引用
    public Image targetImage3; // 添加对目标Image的引用


    public float correct;
    public float wrong;
    public TimePG8 timePG8;
    private void Start()
    {

        // 获得选项的脚本引用
        GameObject OA = GameObject.Find("Button-1");
        AOption = OA.GetComponent<pintu8>();

        GameObject OB = GameObject.Find("Button-2");
        BOption = OB.GetComponent<pintu8>();

        GameObject OC = GameObject.Find("Button-3");
        COption = OC.GetComponent<pintu8>();

        GameObject OD = GameObject.Find("Button-4");
        DOption = OD.GetComponent<pintu8>();
        // 获得选项的脚本引用
        GameObject OE = GameObject.Find("Button-5");
        EOption = OE.GetComponent<pintu8>();

        GameObject OF = GameObject.Find("Button-6");
        FOption = OF.GetComponent<pintu8>();

        GameObject OG = GameObject.Find("Button-7");
        GOption = OG.GetComponent<pintu8>();

        GameObject OH = GameObject.Find("Button-8");
        HOption = OH.GetComponent<pintu8>();
        //Debug.Log("已经引用四个选项脚本");
    }
    public void OnButtonClickA()
    {
        isChoose = false;
        // 检查答案
        CheckAnswer();
        timePG8.ReduceTime(10f);

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
        isChoose = false;
        // 检查答案
        CheckAnswer();
        timePG8.ReduceTime(10f);

    }
    public void OnButtonClickE()
    {

        isChoose = false;
        // 检查答案
        CheckAnswer();
        timePG8.ReduceTime(10f);

    }

    public void OnButtonClickF()
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
    public void OnButtonClickG()
    {

        isChoose = false;
        // 检查答案
        CheckAnswer();
        timePG8.ReduceTime(10f);
    }
    public void OnButtonClickH()
    {
        timePG8.ReduceTime(10f);

        isChoose = false;
        // 检查答案
        CheckAnswer();
        // 修改Image颜色


    }
    private void CheckAnswer()
    {
        //Debug.Log("正在调用答案检查器");
        pintu8 CorrectOption1 = BOption;
        pintu8 CorrectOption2 = COption;
        pintu8 CorrectOption3 = FOption;


        pintu8 WrongOption1 = AOption;
        pintu8 WrongOption2 = DOption;
        pintu8 WrongOption3 = EOption;
        pintu8 WrongOption4 = GOption;
        pintu8 WrongOption5 = HOption;

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
            BOption.correct = 1;
            SceneManager.LoadScene("pintu9");
        }
        else
        {
            Debug.Log("答错啦!");


            AOption.wrong += 1;


        }
    }
}