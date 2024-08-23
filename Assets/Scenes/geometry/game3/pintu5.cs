using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pintu5 : MonoBehaviour
{
    private bool isChoose = false;
    private pintu5 AOption; // 00选项的脚本引用
    private pintu5 BOption; // 01选项的脚本引用
    private pintu5 COption; // 10选项的脚本引用
    private pintu5 DOption; // 11选项的脚本引用
    private pintu5 EOption; // 00选项的脚本引用
    private pintu5 FOption; // 01选项的脚本引用
    private pintu5 GOption; // 10选项的脚本引用
    private pintu5 HOption; // 11选项的脚本引用
    public Image targetImage1; // 添加对目标Image的引用
    public Image targetImage2; // 添加对目标Image的引用
    public Image targetImage3; // 添加对目标Image的引用
    public Image targetImage4; // 添加对目标Image的引用

    public float correct;
    public float wrong;
    public TimePG5 timePG5;
    private void Start()
    {

        // 获得选项的脚本引用
        GameObject OA = GameObject.Find("Button-1");
        AOption = OA.GetComponent<pintu5>();

        GameObject OB = GameObject.Find("Button-2");
        BOption = OB.GetComponent<pintu5>();

        GameObject OC = GameObject.Find("Button-3");
        COption = OC.GetComponent<pintu5>();

        GameObject OD = GameObject.Find("Button-4");
        DOption = OD.GetComponent<pintu5>();
        // 获得选项的脚本引用
        GameObject OE = GameObject.Find("Button-5");
        EOption = OE.GetComponent<pintu5>();

        GameObject OF = GameObject.Find("Button-6");
        FOption = OF.GetComponent<pintu5>();

        GameObject OG = GameObject.Find("Button-7");
        GOption = OG.GetComponent<pintu5>();

        GameObject OH = GameObject.Find("Button-8");
        HOption = OH.GetComponent<pintu5>();

        //Debug.Log("已经引用四个选项脚本");
    }
    public void OnButtonClickB()
    {
        isChoose = false;
        // 检查答案
        CheckAnswer();
        timePG5.ReduceTime(10f);

    }
    public void OnButtonClickA()
    {
        // 切换选择状态
        isChoose = true;
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
        isChoose = true;
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
        isChoose = true;
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
        timePG5.ReduceTime(10f);



    }

    public void OnButtonClickF()
    {
        isChoose = true;
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
        timePG5.ReduceTime(10f);

        isChoose = false;
        // 检查答案
        CheckAnswer();
        // 修改Image颜色

    }
    public void OnButtonClickH()
    {
        timePG5.ReduceTime(10f);

        isChoose = false;
        // 检查答案
        CheckAnswer();
        // 修改Image颜色


    }
    private void CheckAnswer()
    {
        //Debug.Log("正在调用答案检查器");
        pintu5 CorrectOption1 = AOption;
        pintu5 CorrectOption2 = COption;
        pintu5 CorrectOption3 = DOption;
        pintu5 CorrectOption4 = FOption;


        pintu5 WrongOption1 = BOption;
        pintu5 WrongOption2 = EOption;
        pintu5 WrongOption3 = GOption;
        pintu5 WrongOption4 = HOption;
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
            CorrectOption4.isChoose == true &&
            WrongOption1.isChoose == false &&
            WrongOption2.isChoose == false &&
            WrongOption3.isChoose == false &&
            WrongOption4.isChoose == false)
        {
            Debug.Log("答对啦!");
            AOption.correct = 1;
            SceneManager.LoadScene("pintu6");
        }
        else
        {
            Debug.Log("答错啦!");

            BOption.wrong += 1;


        }
    }
}