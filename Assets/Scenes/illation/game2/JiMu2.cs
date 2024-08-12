using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JiMu2 : MonoBehaviour
{
    public Countdown countdown;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;
    public Button button10;
    public Button button11;
    public Button button12;

    void Start()
    {
        button1.onClick.AddListener(OnClick1);
        button2.onClick.AddListener(OnClick2);
        button3.onClick.AddListener(OnClick3);
        button4.onClick.AddListener(OnClick4);
        button5.onClick.AddListener(OnClick5);
        button6.onClick.AddListener(OnClick6);
        button7.onClick.AddListener(OnClick7);
        button8.onClick.AddListener(OnClick8);
        button9.onClick.AddListener(OnClick9);
        button10.onClick.AddListener(OnClick10);
        button11.onClick.AddListener(OnClick11);
        button12.onClick.AddListener(OnClick12);
    }

    public void OnClick1()
    {
        countdown.ReduceTime(10f); // 选择A时减少10秒倒计时
        Debug.Log("选择了1，当前倒计时：" + countdown.timeStart);
    }

    public void OnClick2()
    {
        countdown.ReduceTime(10f); // 选择B时减少10秒倒计时
        Debug.Log("选择了2，当前倒计时：" + countdown.timeStart);
    }

    public void OnClick3()
    {
        countdown.ReduceTime(10f); // 选择B时减少10秒倒计时
        Debug.Log("选择了4，当前倒计时：" + countdown.timeStart);
    }
    public void OnClick4()
    {
        // 选择4时切换到下一个页面
        SwitchToNextPage();
    }
    public void OnClick5()
    {
        countdown.ReduceTime(10f); // 选择B时减少10秒倒计时
        Debug.Log("选择了5，当前倒计时：" + countdown.timeStart);
    }
    public void OnClick6()
    {
        countdown.ReduceTime(10f); // 选择B时减少10秒倒计时
        Debug.Log("选择了6，当前倒计时：" + countdown.timeStart);
    }
    public void OnClick7()
    {
        countdown.ReduceTime(10f); // 选择B时减少10秒倒计时
        Debug.Log("选择了7，当前倒计时：" + countdown.timeStart);
    }
    public void OnClick8()
    {
        countdown.ReduceTime(10f); // 选择B时减少10秒倒计时
        Debug.Log("选择了8，当前倒计时：" + countdown.timeStart);
    }
    public void OnClick9()
    {
        countdown.ReduceTime(10f); // 选择B时减少10秒倒计时
        Debug.Log("选择了9，当前倒计时：" + countdown.timeStart);
    }
    public void OnClick10()
    {
        countdown.ReduceTime(10f); // 选择10时减少10秒倒计时
        Debug.Log("选择了3，当前倒计时：" + countdown.timeStart);
    }
    public void OnClick11()
    {
        countdown.ReduceTime(10f); // 选择B时减少10秒倒计时
        Debug.Log("选择了11，当前倒计时：" + countdown.timeStart);
    }
    public void OnClick12()
    {
        countdown.ReduceTime(10f); // 选择B时减少10秒倒计时
        Debug.Log("选择了12，当前倒计时：" + countdown.timeStart);
    }
    void SwitchToNextPage()
    {
        Debug.Log("切换到下一个页面");
        // 在这里实现切换页面的具体逻辑，例如加载新场景或者显示另一个UI界面
        // 例如，可以使用 Unity 的场景管理器加载新场景：
        SceneManager.LoadScene("JiMu2");
        // 或者显示另一个UI界面：
        // nextUIPanel.SetActive(true);
    }
}
