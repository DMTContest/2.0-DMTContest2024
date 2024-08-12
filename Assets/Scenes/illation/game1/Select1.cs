using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Select1 : MonoBehaviour
{
    public Countdown countdown; // 倒计时管理器的引用
    public Button buttonA;
    public Button buttonB;
    public Button buttonC;
    public float timeStart;

    void Start()
    {
        buttonA.onClick.AddListener(OnClickA);
        buttonB.onClick.AddListener(OnClickB);
        buttonC.onClick.AddListener(OnClickC);
    }

    public void OnClickA()
    {
        countdown.ReduceTime(10f); // 选择A时减少10秒倒计时
        Debug.Log("选择了选项 A，当前倒计时：" + countdown.timeStart);
    }

    public void OnClickB()
    {
        countdown.ReduceTime(10f); // 选择B时减少10秒倒计时
        Debug.Log("选择了选项 B，当前倒计时：" + countdown.timeStart);
    }

    public void OnClickC()
    {
        // 选择C时切换到下一个页面
        SwitchToNextPage();
    }

    void SwitchToNextPage()
    {
        Debug.Log("切换到下一个页面");
        // 在这里实现切换页面的具体逻辑，例如加载新场景或者显示另一个UI界面
        // 例如，可以使用 Unity 的场景管理器加载新场景：
        SceneManager.LoadScene("select2");
        // 或者显示另一个UI界面：
        // nextUIPane.SetActive(true);
    }
}