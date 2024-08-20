using UnityEngine;
using UnityEngine.UI;

public class InputHandler : MonoBehaviour
{
    public InputField inputField1; // 第一个输入框
    public InputField inputField2; // 第二个输入框

    public void StoreInputData()
    {
        GlobalStorage.instance.inputName = inputField1.text; // 存储第一个输入框的内容
        GlobalStorage.instance.inputSlogan = inputField2.text; // 存储第二个输入框的内容
    }


}