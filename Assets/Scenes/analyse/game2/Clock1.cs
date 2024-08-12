using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Threading.Tasks;
public class Clock1 : MonoBehaviour
{

    [SerializeField]private Text textBox;
    [SerializeField]private Text textLost;

    public float timeStart;

    private float rotationSpeed = 30f; // 每秒旋转的角度
    [SerializeField] private SpriteRenderer Minute;
    [SerializeField] private SpriteRenderer Hour;
    [SerializeField] private int TargetNum;
    private int MinuteNum = 0;
    private int MoveNum = 0;

    public float WrongNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        textLost.gameObject.SetActive(false);

        timeStart = 60f;

        StartCoroutine(CountdownRoutine());
    }

    IEnumerator CountdownRoutine()
    {
        while (timeStart > 0f)
        {
            textBox.text = Mathf.Round(timeStart).ToString()+ "s";
            UpdateUI(); // 更新UI
            yield return new WaitForSeconds(1f);
            timeStart -= 1f;
        }
        textBox.text = "0";
        UpdateUI(); // 确保最终时间为0时也更新UI
        Debug.Log("倒计时结束！");
        SceneManager.LoadScene("TimeOver");

    }

    void UpdateUI()
    {
        // 确保在主线程上更新UI
        if (textBox != null)
        {
            textBox.text = Mathf.Round(timeStart).ToString()+"s";
        }
    }

    // 减少倒计时的方法
    public void ReduceTime(float amount)
    {
        timeStart -= amount;
        if (timeStart < 0f)
        {
            timeStart = 0f;
        }
        UpdateUI(); // 每次减少时间时更新UI
    }

public void isWrong()
{
    ReduceTime(10f); // 选择A时减少10秒倒计时
    TimeLostOnce();
    Invoke("TimeLostFalse",0.5f);
    WrongNum += 1;
    
    //Debug.Log("答错啦，当前倒计时：" + timeStart);
}

    public void TimeLostOnce()
    {
        textLost.gameObject.SetActive(true);
    }   

    public void TimeLostFalse()
    {
        textLost.gameObject.SetActive(false);}

    public void isCorrect()
    {
        // 选择C时切换到下一个页面
        
        SwitchToNextPage();
    }

    void SwitchToNextPage()
    {

        SceneManager.LoadScene("AG22");


      
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MoveNum -= 1;
            Minute.transform.RotateAround(new Vector3(-0.5f,-1,0), Vector3.forward, rotationSpeed);
            Hour.transform.RotateAround(new Vector3(-0.5f,-1,0), Vector3.forward, rotationSpeed/12);

            MinuteNum -= 1;
            if (MinuteNum < 0)
            {
                MinuteNum = 11;
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveNum += 1;
            Minute.transform.RotateAround(new Vector3(-0.5f,-1,0), Vector3.forward, -rotationSpeed);
            Hour.transform.RotateAround(new Vector3(-0.5f,-1,0), Vector3.forward, -rotationSpeed/12);
            MinuteNum += 1;
            if (MinuteNum == 12)
            {
                MinuteNum = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (MoveNum == TargetNum)
            {
                Debug.Log("答对啦！");
                isCorrect();
            }
            else
            {
                Debug.Log("答错了......");
                isWrong();
            }
        }
    }

}

