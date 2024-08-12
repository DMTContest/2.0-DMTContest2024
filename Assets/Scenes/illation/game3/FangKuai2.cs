using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FangKuai2 : MonoBehaviour
{
    public Button[] buttons; // 按钮数组或其他点击物体的数组

    void Start()
    {
        // 给每个按钮添加点击事件监听器
        for (int i = 0; i < buttons.Length; i++)
        {
            int index = i; // 保存当前索引以便在闭包中使用
            buttons[i].onClick.AddListener(() => OnButtonClicked(index));
        }
    }

    void OnButtonClicked(int buttonIndex)
    {
        // 处理按钮点击事件
        Debug.Log("Button clicked: " + buttonIndex);

        // 点击后隐藏或销毁按钮
        buttons[buttonIndex].gameObject.SetActive(false); // 隐藏按钮

        // 实现下落逻辑（这里仅作示例，实际项目中需要根据游戏逻辑修改）
        MoveDownObjects();
    }

    void MoveDownObjects()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            if (!buttons[i].gameObject.activeSelf)
            {
                // 物体下落一格，简单演示将上方物体向下移动一个单位
                Vector3 currentPosition = buttons[i].transform.position;
                buttons[i].transform.position = new Vector3(currentPosition.x, currentPosition.y - 1f, currentPosition.z);

                // 在实际项目中可能需要添加移动动画或平滑移动效果
            }
        }
    }
}
