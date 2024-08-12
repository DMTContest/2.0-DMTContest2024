using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Option2 : MonoBehaviour
{
    private bool isChoose = false;
    private Option2 AOption; // 00选项的脚本引用
    private Option2 BOption; // 01选项的脚本引用
    private Option2 COption; // 10选项的脚本引用
    private Option2 DOption; // 11选项的脚本引用

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
        AOption = OA.GetComponent<Option2>();

        GameObject OB = GameObject.Find("Btn_2");
        BOption = OB.GetComponent<Option2>();

        GameObject OC = GameObject.Find("Btn_3");
        COption = OC.GetComponent<Option2>();

        GameObject OD = GameObject.Find("Btn_4");
        DOption = OD.GetComponent<Option2>();

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
        Option2 CorrectOption1 = BOption;
        Option2 CorrectOption2 = COption;

        Option2 WrongOption1 = AOption;
        Option2 WrongOption2 = DOption;

        if (CorrectOption1.isChoose == true &&
            CorrectOption2.isChoose == true &&
            WrongOption1.isChoose == false &&
            WrongOption2.isChoose == false)
        {
            Debug.Log("答对啦!");
            correct = 1;
            //SceneManager.LoadScene("MG2");
        }
    }
}