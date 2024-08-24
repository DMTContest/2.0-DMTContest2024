using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JianYing8 : MonoBehaviour
{
    private bool isChoose = false;
    private JianYing8 AOption; // 00选项的脚本引用
    private JianYing8 BOption; // 01选项的脚本引用
    private JianYing8 COption; // 10选项的脚本引用
    private JianYing8 DOption; // 11选项的脚本引用
    public Image targetImage1; // 添加对目标Image的引用
    public Image targetImage2; // 添加对目标Image的引用

    public float correct;
    public float wrong;
    public TimeYG8 timeYG8;
    private void Start()
    {

        // 获得选项的脚本引用
        GameObject OA = GameObject.Find("Btn_1");
        AOption = OA.GetComponent<JianYing8>();

        GameObject OB = GameObject.Find("Btn_2");
        BOption = OB.GetComponent<JianYing8>();

        GameObject OC = GameObject.Find("Btn_3");
        COption = OC.GetComponent<JianYing8>();

        GameObject OD = GameObject.Find("Btn_4");
        DOption = OD.GetComponent<JianYing8>();

        //Debug.Log("已经引用四个选项脚本");
    }
    public void OnButtonClickA()
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

        isChoose = false;
        // 检查答案
        CheckAnswer();
        timeYG8.ReduceTime(10f);

        COption.wrong += 1;
    }
    public void OnButtonClickD()
    {

        isChoose = false;
        // 检查答案
        CheckAnswer();
        timeYG8.ReduceTime(10f);

        COption.wrong += 1;
    }
    private void CheckAnswer()
    {
        //Debug.Log("正在调用答案检查器");
        JianYing8 CorrectOption1 = AOption;
        JianYing8 CorrectOption2 = BOption;

        JianYing8 WrongOption1 = COption;
        JianYing8 WrongOption2 = DOption;

        if (CorrectOption1.isChoose == true &&
            CorrectOption2.isChoose == true &&
            WrongOption1.isChoose == false &&
            WrongOption2.isChoose == false)
        {
            Debug.Log("答对啦!");
            BOption.correct = 1;
            SceneManager.LoadScene("JianYing9");
        }
        else
        {
            Debug.Log("答错啦!");




        }
    }
}