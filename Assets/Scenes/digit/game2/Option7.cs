using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Option7 : MonoBehaviour
{
    private bool isChoose = false;
    private Option7 AOption; // 00选项的脚本引用
    private Option7 BOption; // 01选项的脚本引用
    private Option7 COption; // 10选项的脚本引用
    private Option7 DOption; // 11选项的脚本引用

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
        AOption = OA.GetComponent<Option7>();

        GameObject OB = GameObject.Find("Btn_2");
        BOption = OB.GetComponent<Option7>();

        GameObject OC = GameObject.Find("Btn_3");
        COption = OC.GetComponent<Option7>();

        GameObject OD = GameObject.Find("Btn_4");
        DOption = OD.GetComponent<Option7>();

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
        Option7 CorrectOption1 = AOption;
        Option7 CorrectOption2 = BOption;

        Option7 WrongOption1 = COption;
        Option7 WrongOption2 = DOption;

        if (CorrectOption1.isChoose == true &&
            CorrectOption2.isChoose == true &&
            WrongOption1.isChoose == false &&
            WrongOption2.isChoose == false)
        {
            Debug.Log("答对啦!");
            AOption.correct = 1;
            SceneManager.LoadScene("DG28");
        }
    }
}