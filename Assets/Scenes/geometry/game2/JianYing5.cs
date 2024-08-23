using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JianYing5 : MonoBehaviour
{
    private bool isChoose = false;
    private JianYing5 AOption; // 00选项的脚本引用
    private JianYing5 BOption; // 01选项的脚本引用
    private JianYing5 COption; // 10选项的脚本引用
    private JianYing5 DOption; // 11选项的脚本引用
    public Image targetImage1; // 添加对目标Image的引用
    public Image targetImage2; // 添加对目标Image的引用

    public Button[] choiceButtons; // 选择按钮数组
    public Image silhouetteImage1; // 第一个剪影图片
    public Image silhouetteImage2; // 第二个剪影图片

    private int correctButtonIndex1 = 1; // 第一个正确按钮的索引
    private int correctButtonIndex2 = 3; // 第二个正确按钮的索引

    private bool buttonClicked1 = false; // 记录第一个按钮是否被点击
    private bool buttonClicked2 = false; // 记录第二个按钮是否被点击

    public float correct;
    public float wrong;
    public TimeYG5 timeYG5;
    private void Start()
    {

        // 获得选项的脚本引用
        GameObject OA = GameObject.Find("Btn_1");
        AOption = OA.GetComponent<JianYing5>();

        GameObject OB = GameObject.Find("Btn_2");
        BOption = OB.GetComponent<JianYing5>();

        GameObject OC = GameObject.Find("Btn_3");
        COption = OC.GetComponent<JianYing5>();

        GameObject OD = GameObject.Find("Btn_4");
        DOption = OD.GetComponent<JianYing5>();

        //Debug.Log("已经引用四个选项脚本");
    }
    public void OnButtonClickA()
    {

        isChoose = false;
        // 检查答案
        CheckAnswer();
        timeYG5.ReduceTime(10f);
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
        timeYG5.ReduceTime(10f);
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
        JianYing5 CorrectOption1 = BOption;
        JianYing5 CorrectOption2 = DOption;

        JianYing5 WrongOption1 = AOption;
        JianYing5 WrongOption2 = COption;

        if (CorrectOption1.isChoose == true &&
            CorrectOption2.isChoose == true &&
            WrongOption1.isChoose == false &&
            WrongOption2.isChoose == false)
        {
            Debug.Log("答对啦!");
            BOption.correct = 1;
            SceneManager.LoadScene("JianYing6");
        }
        else
        {
            Debug.Log("答错啦!");


            AOption.wrong += 1;


        }
    }
}