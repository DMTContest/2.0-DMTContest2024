using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JianYing4 : MonoBehaviour
{
    private bool isChoose = false;
    private JianYing4 AOption; // 00选项的脚本引用
    private JianYing4 BOption; // 01选项的脚本引用
    private JianYing4 COption; // 10选项的脚本引用
    private JianYing4 DOption; // 11选项的脚本引用
    public Image targetImage1; // 添加对目标Image的引用
    public Image targetImage2; // 添加对目标Image的引用

    public float correct;
    public float wrong;
    public TimeYG4 timeYG4;
    private void Start()
    {

        // 获得选项的脚本引用
        GameObject OA = GameObject.Find("Btn_1");
        AOption = OA.GetComponent<JianYing4>();

        GameObject OB = GameObject.Find("Btn_2");
        BOption = OB.GetComponent<JianYing4>();

        GameObject OC = GameObject.Find("Btn_3");
        COption = OC.GetComponent<JianYing4>();

        GameObject OD = GameObject.Find("Btn_4");
        DOption = OD.GetComponent<JianYing4>();

        //Debug.Log("已经引用四个选项脚本");
    }


    public void OnButtonClickA()
    {

        isChoose = false;
        // 检查答案
        CheckAnswer();
        timeYG4.ReduceTime(10f);
        BOption.wrong += 1;
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

    public void OnButtonClickB()
    {

        isChoose = false;
        // 检查答案
        CheckAnswer();
        timeYG4.ReduceTime(10f);
        BOption.wrong += 1;
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
    private void CheckAnswer()
    {
        //Debug.Log("正在调用答案检查器");
        JianYing4 CorrectOption1 = COption;
        JianYing4 CorrectOption2 = DOption;

        JianYing4 WrongOption1 = BOption;
        JianYing4 WrongOption2 = AOption;

        if (CorrectOption1.isChoose == true &&
            CorrectOption2.isChoose == true &&
            WrongOption1.isChoose == false &&
            WrongOption2.isChoose == false)
        {
            Debug.Log("答对啦!");
            COption.correct = 1;
            SceneManager.LoadScene("JianYing5");
        }
    }
}