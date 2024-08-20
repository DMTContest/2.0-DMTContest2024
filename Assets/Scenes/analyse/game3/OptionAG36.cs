using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionAG36 : MonoBehaviour
{

    public TimeAG36 timeAG11;

    private bool isChoose = false;
    private OptionAG36 AOption; // 00选项的脚本引用
    private OptionAG36 BOption; // 01选项的脚本引用
    private OptionAG36 COption; // 10选项的脚本引用
    private OptionAG36 DOption; // 11选项的脚本引用

    [SerializeField] private Sprite chosenSprite; // 选择状态下的Sprite
    [SerializeField] private Sprite unchosenSprite; // 未选择状态下的Sprite

    private Image buttonImage; // 用于更改Sprite的Image组件

    private Image AbuttonImage; // 用于更改Sprite的Image组件
    private Image BbuttonImage; // 用于更改Sprite的Image组件
    private Image CbuttonImage; // 用于更改Sprite的Image组件
    private Image DbuttonImage; // 用于更改Sprite的Image组件


    public float correct = 0;
    public float wrong = 0;


    private void Start()
    {
        //Debug.Log("正在调用答案检查器");

        // 获取当前Button的Image组件

        buttonImage = GetComponent<Image>();

        // 获得选项的脚本引用
        GameObject OA = GameObject.Find("Btn_1");

        AbuttonImage = OA.GetComponent<Image>();
        AOption = OA.GetComponent<OptionAG36>();

        GameObject OB = GameObject.Find("Btn_2");

        BbuttonImage = OB.GetComponent<Image>();
        BOption = OB.GetComponent<OptionAG36>();

        GameObject OC = GameObject.Find("Btn_3");
        COption = OC.GetComponent<OptionAG36>();

        GameObject OD = GameObject.Find("Btn_4");
        DOption = OD.GetComponent<OptionAG36>();

        CbuttonImage = OC.GetComponent<Image>();
        DbuttonImage = OD.GetComponent<Image>();

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


        if (AOption.isChoose == true &&
            BOption.isChoose == false &&
            COption.isChoose == false &&
            DOption.isChoose == false)
        {
            Debug.Log("答对啦!");
            AOption.correct = 1;
            SceneManager.LoadScene("AG37");
        }
        else
        {
            Debug.Log("答错啦!");

            timeAG11.ReduceTime(10f);

            BOption.wrong += 1;

            ResetOptions();
        }
    }

    private void ResetOptions()
    {
        // 重置选项A
        AOption.isChoose = false;
        AbuttonImage.sprite = AOption.unchosenSprite; // 使用未选择的Sprite

        // 重置选项B
        BOption.isChoose = false;
        BbuttonImage.sprite = BOption.unchosenSprite; // 使用未选择的Sprite

        // 重置选项C
        COption.isChoose = false;
        CbuttonImage.sprite = COption.unchosenSprite; // 使用未选择的Sprite

        // 重置选项B
        DOption.isChoose = false;
        DbuttonImage.sprite = DOption.unchosenSprite; // 使用未选择的Sprite


    }
}