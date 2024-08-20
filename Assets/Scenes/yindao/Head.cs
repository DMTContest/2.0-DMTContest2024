using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;
public class Head : MonoBehaviour
{
    [SerializeField] Image head;
    public Text displayName; // 第一个显示文本的组件
    public Text displaySlogan; // 第二个显示文本的组件
    // Start is called before the first frame update
    void Start()
    {
        head.sprite = GlobalStorage.HeadImage;
        displayName.text = GlobalStorage.instance.inputName; // 设置第一个文本
        displaySlogan.text = GlobalStorage.instance.inputSlogan; // 设置第二个文本
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
