using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class BtM6 : MonoBehaviour, IPointerClickHandler
{
    public Button[] buttons; // 按钮数组
    private bool[] buttonStates; // 按钮状态数组
    public TimeFG6 timeFG6; // 引用到 Countdown 脚本

    void Start()
    {
        buttonStates = new bool[buttons.Length];

        for (int i = 0; i < buttons.Length; i++)
        {
            int index = i; // Capture the current index for the lambda
            buttons[i].onClick.AddListener(() => OnButtonClicked(index));
        }
    }

    void OnButtonClicked(int index)
    {
        buttonStates[index] = true;
        CheckAllButtonsClicked();
    }

    void CheckAllButtonsClicked()
    {
        foreach (bool state in buttonStates)
        {
            if (!state) return;
        }

        // 所有按钮都被点击了，进行页面跳转
        SceneManager.LoadScene("FangKuai7"); // 替换成你的目标场景名称
    }

    // IPointerClickHandler method
    public void OnPointerClick(PointerEventData eventData)
    {
        // Check if the clicked object is not in the buttons array
        GameObject clickedObject = eventData.pointerPress;
        bool isButton = System.Array.Exists(buttons, button => button.gameObject == clickedObject);

        if (!isButton)
        {
            // Reduce time by 10 seconds
            if (timeFG6 != null)
            {
                timeFG6.ReduceTime(10f);
            }
        }
    }
}