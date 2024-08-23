using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JianYing2 : MonoBehaviour
{
    private bool isChoose = false;
    private JianYing2 AOption; // 00选项的脚本引用
    private JianYing2 BOption; // 01选项的脚本引用
    private JianYing2 COption; // 10选项的脚本引用
    private JianYing2 DOption; // 11选项的脚本引用
    public Image targetImage1; // 添加对目标Image的引用


    public float correct;
    public float wrong;
    public TimeYG2 timeYG2;
    private void Start()
    {

        // 获得选项的脚本引用
        GameObject OA = GameObject.Find("Btn_1");
        AOption = OA.GetComponent<JianYing2>();

        GameObject OB = GameObject.Find("Btn_2");
        BOption = OB.GetComponent<JianYing2>();

        GameObject OC = GameObject.Find("Btn_3");
        COption = OC.GetComponent<JianYing2>();

        GameObject OD = GameObject.Find("Btn_4");
        DOption = OD.GetComponent<JianYing2>();

        //Debug.Log("已经引用四个选项脚本");
    }
    public void OnButtonClickB()
    {
        isChoose = false;
        // 检查答案
        CheckAnswer();
        timeYG2.ReduceTime(10f);
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
       
        
        // 检查答案
        CheckAnswer();

        timeYG2.ReduceTime(10f);

        isChoose = false;
        // 检查答案
    }
    public void OnButtonClickD()
    {
        timeYG2.ReduceTime(10f);

        isChoose = false;
        // 检查答案
        CheckAnswer();
        // 修改Image颜色
        

    }
    private void CheckAnswer()
    {
        //Debug.Log("正在调用答案检查器");
        JianYing2 CorrectOption1 = AOption;


        JianYing2 WrongOption1 = BOption;
        JianYing2 WrongOption2 = DOption;
        JianYing2 WrongOption3 = COption;

        if (CorrectOption1.isChoose == true &&
            WrongOption3.isChoose == false &&
            WrongOption1.isChoose == false &&
            WrongOption2.isChoose == false)
        {
            Debug.Log("答对啦!");
            AOption.correct = 1;
            SceneManager.LoadScene("JianYing3");
        }
        else
        {
            Debug.Log("答错啦!");


            BOption.wrong += 1;


        }
    }
}