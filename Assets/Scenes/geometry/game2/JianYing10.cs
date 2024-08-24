using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JianYing10 : MonoBehaviour
{
    private bool isChoose = false;
    private JianYing10 AOption; // 00选项的脚本引用
    private JianYing10 BOption; // 01选项的脚本引用
    private JianYing10 COption; // 10选项的脚本引用
    private JianYing10 DOption; // 11选项的脚本引用
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
    public TimeYG10 timeYG10;
    private void Start()
    {

        // 获得选项的脚本引用
        GameObject OA = GameObject.Find("Btn_1");
        AOption = OA.GetComponent<JianYing10>();

        GameObject OB = GameObject.Find("Btn_2");
        BOption = OB.GetComponent<JianYing10>();

        GameObject OC = GameObject.Find("Btn_3");
        COption = OC.GetComponent<JianYing10>();

        GameObject OD = GameObject.Find("Btn_4");
        DOption = OD.GetComponent<JianYing10>();

        //Debug.Log("已经引用四个选项脚本");
    }
    public void OnButtonClickB()
    {

        isChoose = false;
        // 检查答案
        CheckAnswer();
        timeYG10.ReduceTime(10f);
        BOption.wrong += 1;
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

        if (targetImage2 != null)
        {
            targetImage2.color = Color.green; // 将颜色设置为绿色
        }

    }
    public void OnButtonClickD()
    {
        timeYG10.ReduceTime(10f);

        isChoose = false;
        // 检查答案
        CheckAnswer();
        // 修改Image颜色
        BOption.wrong += 1;


    }
    private void CheckAnswer()
    {
        //Debug.Log("正在调用答案检查器");
        JianYing10 CorrectOption1 = AOption;
        JianYing10 CorrectOption2 = COption;

        JianYing10 WrongOption1 = BOption;
        JianYing10 WrongOption2 = DOption;

        if (CorrectOption1.isChoose == true &&
            CorrectOption2.isChoose == true &&
            WrongOption1.isChoose == false &&
            WrongOption2.isChoose == false)
        {
            Debug.Log("答对啦!");
            AOption.correct = 1;
            SceneManager.LoadScene("YGFinal");
        }
        else
        {
            Debug.Log("答错啦!");





        }
    }
}