using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pintu10 : MonoBehaviour
{
    private bool isChoose = false;
    private pintu10 AOption; // 00选项的脚本引用
    private pintu10 BOption; // 01选项的脚本引用
    private pintu10 COption; // 10选项的脚本引用
    private pintu10 DOption; // 11选项的脚本引用
    private pintu10 EOption; // 00选项的脚本引用
    private pintu10 FOption; // 01选项的脚本引用
    private pintu10 GOption; // 10选项的脚本引用
    private pintu10 HOption; // 11选项的脚本引用
    public Image targetImage1; // 添加对目标Image的引用
    public Image targetImage2; // 添加对目标Image的引用
    public Image targetImage3; // 添加对目标Image的引用


    public float correct;
    public float wrong;
    public TimePG10 timePG10;
    private void Start()
    {

        // 获得选项的脚本引用
        GameObject OA = GameObject.Find("Button-1");
        AOption = OA.GetComponent<pintu10>();

        GameObject OB = GameObject.Find("Button-2");
        BOption = OB.GetComponent<pintu10>();

        GameObject OC = GameObject.Find("Button-3");
        COption = OC.GetComponent<pintu10>();

        GameObject OD = GameObject.Find("Button-4");
        DOption = OD.GetComponent<pintu10>();
        // 获得选项的脚本引用
        GameObject OE = GameObject.Find("Button-5");
        EOption = OE.GetComponent<pintu10>();

        GameObject OF = GameObject.Find("Button-6");
        FOption = OF.GetComponent<pintu10>();

        GameObject OG = GameObject.Find("Button-7");
        GOption = OG.GetComponent<pintu10>();

        GameObject OH = GameObject.Find("Button-8");
        HOption = OH.GetComponent<pintu10>();

        //Debug.Log("已经引用四个选项脚本");
    }
    public void OnButtonClickA()
    {
        isChoose = false;
        // 检查答案
        CheckAnswer();
        timePG10.ReduceTime(10f);

    }
    public void OnButtonClickB()
    {
        isChoose = false;
        // 检查答案
        CheckAnswer();
        timePG10.ReduceTime(10f);
        AOption.wrong += 1;

    }

    public void OnButtonClickC()
    {
        isChoose = false;
        // 检查答案
        CheckAnswer();
        timePG10.ReduceTime(10f);
        AOption.wrong += 1;

    }
    public void OnButtonClickD()
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
    public void OnButtonClickE()
    {

        isChoose = false;
        // 检查答案
        CheckAnswer();
        timePG10.ReduceTime(10f);
        AOption.wrong += 1;
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
        timePG10.ReduceTime(10f);
        AOption.wrong += 1;
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
        pintu10 CorrectOption1 = DOption;
        pintu10 CorrectOption2 = FOption;
        pintu10 CorrectOption3 = HOption;


        pintu10 WrongOption1 = AOption;
        pintu10 WrongOption2 = BOption;
        pintu10 WrongOption3 = COption;
        pintu10 WrongOption4 = EOption;
        pintu10 WrongOption5 = GOption;

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
            DOption.correct = 1;
            SceneManager.LoadScene("PGFinal");
        }
        else
        {
            Debug.Log("答错啦!");
           


        }
    }
}