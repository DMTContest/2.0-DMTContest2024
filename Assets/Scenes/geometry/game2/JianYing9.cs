using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JianYing9 : MonoBehaviour
{
    private bool isChoose = false;
    private JianYing9 AOption; // 00选项的脚本引用
    private JianYing9 BOption; // 01选项的脚本引用
    private JianYing9 COption; // 10选项的脚本引用
    private JianYing9 DOption; // 11选项的脚本引用
    public Image targetImage1; // 添加对目标Image的引用
    public Image targetImage2; // 添加对目标Image的引用

    public float correct;
    public float wrong;
    public TimeYG9 timeYG9;
    private void Start()
    {

        // 获得选项的脚本引用
        GameObject OA = GameObject.Find("Btn_1");
        AOption = OA.GetComponent<JianYing9>();

        GameObject OB = GameObject.Find("Btn_2");
        BOption = OB.GetComponent<JianYing9>();

        GameObject OC = GameObject.Find("Btn_3");
        COption = OC.GetComponent<JianYing9>();

        GameObject OD = GameObject.Find("Btn_4");
        DOption = OD.GetComponent<JianYing9>();

        //Debug.Log("已经引用四个选项脚本");
    }
    public void OnButtonClickA()
    {

        isChoose = false;
        // 检查答案
        CheckAnswer();
        timeYG9.ReduceTime(10f);
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
        timeYG9.ReduceTime(10f);
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
        JianYing9 CorrectOption1 = BOption;
        JianYing9 CorrectOption2 = DOption;

        JianYing9 WrongOption1 = AOption;
        JianYing9 WrongOption2 = COption;

        if (CorrectOption1.isChoose == true &&
            CorrectOption2.isChoose == true &&
            WrongOption1.isChoose == false &&
            WrongOption2.isChoose == false)
        {
            Debug.Log("答对啦!");
            BOption.correct = 1;
            SceneManager.LoadScene("JianYing10");
        }
        else
        {
            Debug.Log("答错啦!");


            AOption.wrong += 1;


        }
    }
}