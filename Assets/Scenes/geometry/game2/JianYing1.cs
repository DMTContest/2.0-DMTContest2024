using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JianYing1 : MonoBehaviour
{
    private bool isChoose = false;
    private JianYing1 AOption; // 00选项的脚本引用
    private JianYing1 BOption; // 01选项的脚本引用
    private JianYing1 COption; // 10选项的脚本引用
    private JianYing1 DOption; // 11选项的脚本引用
    public Image targetImage1; // 添加对目标Image的引用


    public float correct;
    public float wrong;
    public TimeYG1 timeYG1;
    private void Start()
    {

        // 获得选项的脚本引用
        GameObject OA = GameObject.Find("Btn_1");
        AOption = OA.GetComponent<JianYing1>();

        GameObject OB = GameObject.Find("Btn_2");
        BOption = OB.GetComponent<JianYing1>();

        GameObject OC = GameObject.Find("Btn_3");
        COption = OC.GetComponent<JianYing1>();

        GameObject OD = GameObject.Find("Btn_4");
        DOption = OD.GetComponent<JianYing1>();

        //Debug.Log("已经引用四个选项脚本");
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
    public void OnButtonClickA()
    {

        isChoose = false;
        // 检查答案
        CheckAnswer();
        timeYG1.ReduceTime(10f);



    }

    public void OnButtonClickC()
    {


        // 检查答案
        CheckAnswer();

        timeYG1.ReduceTime(10f);

        isChoose = false;
        // 检查答案
    }
    public void OnButtonClickD()
    {
        timeYG1.ReduceTime(10f);

        isChoose = false;
        // 检查答案
        CheckAnswer();
        // 修改Image颜色


    }
    private void CheckAnswer()
    {
        //Debug.Log("正在调用答案检查器");
        JianYing1 CorrectOption1 = BOption;


        JianYing1 WrongOption1 = AOption;
        JianYing1 WrongOption2 = DOption;
        JianYing1 WrongOption3 = COption;

        if (CorrectOption1.isChoose == true &&
            WrongOption3.isChoose == false &&
            WrongOption1.isChoose == false &&
            WrongOption2.isChoose == false)
        {
            Debug.Log("答对啦!");
            BOption.correct = 1;
            SceneManager.LoadScene("JianYing2");
        }
        else
        {
            Debug.Log("答错啦!");


            AOption.wrong += 1;


        }
    }
}