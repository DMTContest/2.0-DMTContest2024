using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Option9 : MonoBehaviour
{
    private bool isChoose = false;
    private Option9 AOption; // 00选项的脚本引用
    private Option9 BOption; // 01选项的脚本引用
    private Option9 COption; // 10选项的脚本引用
    private Option9 DOption; // 11选项的脚本引用

    [SerializeField] private Sprite chosenSprite; // 选择状态下的Sprite
    [SerializeField] private Sprite unchosenSprite; // 未选择状态下的Sprite
    private Image buttonImage; // 用于更改Sprite的Image组件
    public float correct;

    private void Start()
    {
        // 获取当前Button的Image组件
        buttonImage = GetComponent<Image>();

        // 获得选项的脚本引用
        GameObject OA = GameObject.Find("Btn_1");
        AOption = OA.GetComponent<Option9>();

        GameObject OB = GameObject.Find("Btn_2");
        BOption = OB.GetComponent<Option9>();

        GameObject OC = GameObject.Find("Btn_3");
        COption = OC.GetComponent<Option9>();

        GameObject OD = GameObject.Find("Btn_4");
        DOption = OD.GetComponent<Option9>();

        //Debug.Log("已经引用四个选项脚本");
    }

    public void OnButtonClick()
    {
        // 切换选择状态
        isChoose = !isChoose;
        
        // 更改Sprite
        ChangeSprite();

        // 检查答案
        CheckAnswer();
    }

    private void ChangeSprite()
    {
        if (isChoose)
        {
            buttonImage.sprite = chosenSprite;
            //Debug.Log("Sprite为已选择");
        }
        else
        {
            buttonImage.sprite = unchosenSprite;
            //Debug.Log("Sprite为未选择");
        }
    }

    private void CheckAnswer()
    {
        //Debug.Log("正在调用答案检查器");
        Option9 CorrectOption1 = COption;
        Option9 CorrectOption2 = DOption;
        Option9 CorrectOption3 = BOption;


        Option9 WrongOption1 = AOption;

        if (CorrectOption1.isChoose == true &&
            CorrectOption2.isChoose == true &&
            CorrectOption3.isChoose == true &&
            WrongOption1.isChoose == false)
        {
            Debug.Log("答对啦!");
            AOption.correct = 1;
            SceneManager.LoadScene("DG210");
        }
    }
}