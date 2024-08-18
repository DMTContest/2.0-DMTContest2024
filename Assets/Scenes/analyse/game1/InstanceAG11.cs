using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstanceAG11 : MonoBehaviour
{
    private static InstanceAG11 instance = null;
    public float _time = 0f;
    public float JCorrect;
    public float JCorrect1;
    public float JCorrect2;
    public float JCorrect3;
    public float MCorrect;
    public float MCorrect1;
    public float MCorrect2;
    public float MCorrect3;
    public float HCorrect;
    public float HCorrect1;
    public float HCorrect2;
    public float HCorrect3;
    public float HCorrect4;
    public float JWrong1;
    public float JWrong2;
    public float JWrong3;
    public float MWrong1;
    public float MWrong2;
    public float MWrong3;
    public float HWrong1;
    public float HWrong2;
    public float HWrong3;
    public float HWrong4;
    public string ScoreForDigitWind;
    public float FinalScoreFromMG1;
    public bool firstTime = true;


    private void Awake()
    {
        // 确保只有一个 SceneTransition 实例
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "AG11")
        {
            JCorrect1 = GetCorrectFromScene1();

            _time = GetTimeFromScene1();

            JWrong1 = GetWrongNumFromScene1();

            Debug.Log("JCorrect1 : " + JCorrect1);
            Debug.Log("JWrong1 :" + JWrong1);
        }
        if (SceneManager.GetActiveScene().name == "AG12")
        {
            JCorrect2 = GetCorrectFromScene2();

            _time = GetTimeFromScene2();

            JWrong2 = GetWrongNumFromScene2();

            Debug.Log("JCorrect2 : " + JCorrect2);
            Debug.Log("JWrong2 :" + JWrong2);

        }
        if (SceneManager.GetActiveScene().name == "AG13")
        {
            JCorrect3 = GetCorrectFromScene3();

            _time = GetTimeFromScene3();

            JWrong3 = GetWrongNumFromScene3();

            Debug.Log("JCorrect3 : " + JCorrect3);
            Debug.Log("JWrong3 :" + JWrong3);

        }
        if (SceneManager.GetActiveScene().name == "AG14")
        {
            MCorrect1 = GetCorrectFromScene4();

            _time = GetTimeFromScene4();

            MWrong1 = GetWrongNumFromScene4();
        }
        if (SceneManager.GetActiveScene().name == "AG15")
        {
            MCorrect2 = GetCorrectFromScene5();
            _time = GetTimeFromScene5();

            MWrong2 = GetWrongNumFromScene5();

        }
        if (SceneManager.GetActiveScene().name == "AG16")
        {
            MCorrect3 = GetCorrectFromScene6();

            _time = GetTimeFromScene6();

            MWrong3 = GetWrongNumFromScene6();

        }
        if (SceneManager.GetActiveScene().name == "AG17")
        {
            HCorrect1 = GetCorrectFromScene7();

            _time = GetTimeFromScene7();

            HWrong1 = GetWrongNumFromScene7();
        }
        if (SceneManager.GetActiveScene().name == "AG18")
        {
            HCorrect2 = GetCorrectFromScene8();
            _time = GetTimeFromScene8();

            HWrong2 = GetWrongNumFromScene8();

        }
        if (SceneManager.GetActiveScene().name == "AG19")
        {
            HCorrect3 = GetCorrectFromScene9();

            _time = GetTimeFromScene9();

            HWrong3 = GetWrongNumFromScene9();

        }
        if (SceneManager.GetActiveScene().name == "AG110")
        {
            HCorrect4 = GetCorrectFromScene10();

            _time = GetTimeFromScene10();

            HWrong4 = GetWrongNumFromScene10();
        }
        if (SceneManager.GetActiveScene().name == "AG1Final")
        {
            ScoreForDigitWind =
         (
            Jcorrect * 10 - (JWR1 + JWR2 + JWR3) * 10
         + Mcorrect * 10 - (MWR1 + MWR2 + MWR3) * 10
         + Hcorrect * 10 - (HWR1 + HWR2 + HWR3 + HWR4) * 10
         ).ToString();
            FinalScoreFromMG1 = Jcorrect * 10 - (JWR1 + JWR2 + JWR3) * 10
        + Mcorrect * 10 - (MWR1 + MWR2 + MWR3) * 10
        + Hcorrect * 10 - (HWR1 + HWR2 + HWR3 + HWR4) * 10;

            firstTime = false;



        }
    }

    private float GetTimeFromScene1()
    {
        // 查 Clock1 脚本并获取其 time 属性的值
        TimeAG11 c = FindObjectOfType<TimeAG11>();
        if (c != null)
        {
            return c.timeStart;
            
        }
        else
        {
            return 0f;
        }
    }
    private float GetWrongNumFromScene1()
    {
        GameObject OB = GameObject.Find("Btn_2");
        OptionAG11 c = OB.GetComponent<OptionAG11>();
        if (c != null)
        {
            return c.wrong;
        }
        else
        {
            return 0f;
        }
    }
    private float GetCorrectFromScene1()
    {
        // 查找 Clock1 脚本并获取其 time 属性的值
        GameObject OA = GameObject.Find("Btn_1");
        OptionAG11 c = OA.GetComponent<OptionAG11>();
        if (c != null)
        {
            return c.correct;
       
        }
        else
        {
            return 0f;
        }
    }

    public static float Time
    {
        get { return instance != null ? instance._time : 0f; }
    }

    public static float Jcorrect
    {
        get { return instance != null ? instance.JCorrect1 + instance.JCorrect2 + instance.JCorrect3 : 0f; }
    }
    public static float Mcorrect
    {
        get { return instance != null ? instance.MCorrect1 + instance.MCorrect2 + instance.MCorrect3 : 0f; }
    }
    public static float Hcorrect
    {
        get { return instance != null ? instance.HCorrect1 + instance.HCorrect2 + instance.HCorrect3 + instance.HCorrect4 : 0f; }
    }
    public static float JWR1
    {
        get { return instance != null ? instance.JWrong1 : 0f; }
    }
    public static float JWR2
    {
        get { return instance != null ? instance.JWrong2 : 0f; }
    }
    public static float JWR3
    {
        get { return instance != null ? instance.JWrong3 : 0f; }
    }
    public static float MWR1
    {
        get { return instance != null ? instance.MWrong1 : 0f; }
    }
    public static float MWR2
    {
        get { return instance != null ? instance.MWrong2 : 0f; }
    }
    public static float MWR3
    {
        get { return instance != null ? instance.MWrong3 : 0f; }
    }
    public static float HWR1
    {
        get { return instance != null ? instance.HWrong1 : 0f; }
    }
    public static float HWR2
    {
        get { return instance != null ? instance.HWrong2 : 0f; }
    }
    public static float HWR3
    {
        get { return instance != null ? instance.HWrong3 : 0f; }
    }
    public static float HWR4
    {
        get { return instance != null ? instance.HWrong4 : 0f; }
    }
    public static string RecordScore
    {
        get { return instance != null ? instance.ScoreForDigitWind : null; }
    }
    public static float FinalScoreForMG1
    {
        get { return instance != null ? instance.FinalScoreFromMG1 : 0f; }
    }
    public static bool FirstTime
    {
        get { return instance != null ? instance.firstTime : true; }
    }

    private float GetTimeFromScene2()
    {
        // 查 Clock1 脚本并获取其 time 属性的值
        TimeAG12 c = FindObjectOfType<TimeAG12>();
        if (c != null)
        {
            return c.timeStart;

        }
        else
        {
            return 0f;
        }
    }
    private float GetWrongNumFromScene2()
    {
        GameObject OB = GameObject.Find("Btn_1");
        OptionAG12 c = OB.GetComponent<OptionAG12>();
        if (c != null)
        {
            return c.wrong;
        }
        else
        {
            return 0f;
        }
    }
    private float GetCorrectFromScene2()
    {
        // 查找 Clock1 脚本并获取其 time 属性的值
        GameObject OA = GameObject.Find("Btn_2");
        OptionAG12 c = OA.GetComponent<OptionAG12>();
        if (c != null)
        {
            return c.correct;

        }
        else
        {
            return 0f;
        }
    }

    private float GetTimeFromScene3()
    {
        // 查 Clock1 脚本并获取其 time 属性的值
        TimeAG13 c = FindObjectOfType<TimeAG13>();
        if (c != null)
        {
            return c.timeStart;

        }
        else
        {
            return 0f;
        }
    }
    private float GetWrongNumFromScene3()
    {
        GameObject OB = GameObject.Find("Btn_1");
        OptionAG13 c = OB.GetComponent<OptionAG13>();
        if (c != null)
        {
            return c.wrong;
        }
        else
        {
            return 0f;
        }
    }
    private float GetCorrectFromScene3()
    {
        // 查找 Clock1 脚本并获取其 time 属性的值
        GameObject OA = GameObject.Find("Btn_2");
        OptionAG13 c = OA.GetComponent<OptionAG13>();
        if (c != null)
        {
            return c.correct;

        }
        else
        {
            return 0f;
        }
    }
    private float GetTimeFromScene4()
    {
        // 查 Clock1 脚本并获取其 time 属性的值
        TimeAG14 c = FindObjectOfType<TimeAG14>();
        if (c != null)
        {
            return c.timeStart;
        }
        else
        {
            return 0f;
        }
    }
    private float GetWrongNumFromScene4()
    {
        GameObject OB = GameObject.Find("Btn_2");
        OptionAG14 c = OB.GetComponent<OptionAG14>();
        if (c != null)
        {
            return c.wrong;
        }
        else
        {
            return 0f;
        }
    }
    private float GetCorrectFromScene4()
    {
        // 查找 Clock1 脚本并获取其 time 属性的值
        GameObject OA = GameObject.Find("Btn_3");
        OptionAG14 c = OA.GetComponent<OptionAG14>();
        if (c != null)
        {
            return c.correct;
        }
        else
        {
            return 0f;
        }
    }
    private float GetTimeFromScene5()
    {
        // 查 Clock1 脚本并获取其 time 属性的值
        TimeAG15 c = FindObjectOfType<TimeAG15>();
        if (c != null)
        {
            return c.timeStart;
        }
        else
        {
            return 0f;
        }
    }
    private float GetWrongNumFromScene5()
    {
        GameObject OB = GameObject.Find("Btn_3");
        OptionAG15 c = OB.GetComponent<OptionAG15>();
        if (c != null)
        {
            return c.wrong;
        }
        else
        {
            return 0f;
        }
    }
    private float GetCorrectFromScene5()
    {
        // 查找 Clock1 脚本并获取其 time 属性的值
        GameObject OA = GameObject.Find("Btn_2");
        OptionAG15 c = OA.GetComponent<OptionAG15>();
        if (c != null)
        {
            return c.correct;
        }
        else
        {
            return 0f;
        }
    }

    private float GetTimeFromScene6()
    {
        // 查 Clock1 脚本并获取其 time 属性的值
        TimeAG16 c = FindObjectOfType<TimeAG16>();
        if (c != null)
        {
            return c.timeStart;
        }
        else
        {
            return 0f;
        }
    }
    private float GetWrongNumFromScene6()
    {
        GameObject OB = GameObject.Find("Btn_2");
        OptionAG16 c = OB.GetComponent<OptionAG16>();
        if (c != null)
        {
            return c.wrong;
        }
        else
        {
            return 0f;
        }
    }
    private float GetCorrectFromScene6()
    {
        // 查找 Clock1 脚本并获取其 time 属性的值
        GameObject OA = GameObject.Find("Btn_1");
        OptionAG16 c = OA.GetComponent<OptionAG16>();
        if (c != null)
        {
            return c.correct;
        }
        else
        {
            return 0f;
        }
    }
    private float GetTimeFromScene7()
    {
        // 查 Clock1 脚本并获取其 time 属性的值
        TimeAG17 c = FindObjectOfType<TimeAG17>();
        if (c != null)
        {
            return c.timeStart;
        }
        else
        {
            return 0f;
        }
    }
    private float GetWrongNumFromScene7()
    {
        GameObject OB = GameObject.Find("Btn_1");
        OptionAG17 c = OB.GetComponent<OptionAG17>();
        if (c != null)
        {
            return c.wrong;
        }
        else
        {
            return 0f;
        }
    }
    private float GetCorrectFromScene7()
    {
        // 查找 Clock1 脚本并获取其 time 属性的值
        GameObject OA = GameObject.Find("Btn_2");
        OptionAG17 c = OA.GetComponent<OptionAG17>();
        if (c != null)
        {
            return c.correct;
        }
        else
        {
            return 0f;
        }
    }
    private float GetTimeFromScene8()
    {
        // 查 Clock1 脚本并获取其 time 属性的值
        TimeAG18 c = FindObjectOfType<TimeAG18>();
        if (c != null)
        {
            return c.timeStart;
        }
        else
        {
            return 0f;
        }
    }
    private float GetWrongNumFromScene8()
    {
        GameObject OB = GameObject.Find("Btn_1");
        OptionAG18 c = OB.GetComponent<OptionAG18>();
        if (c != null)
        {
            return c.wrong;
        }
        else
        {
            return 0f;
        }
    }
    private float GetCorrectFromScene8()
    {
        // 查找 Clock1 脚本并获取其 time 属性的值
        GameObject OA = GameObject.Find("Btn_3");
        OptionAG18 c = OA.GetComponent<OptionAG18>();
        if (c != null)
        {
            return c.correct;
        }
        else
        {
            return 0f;
        }
    }
    private float GetTimeFromScene9()
    {
        // 查 Clock1 脚本并获取其 time 属性的值
        TimeAG19 c = FindObjectOfType<TimeAG19>();
        if (c != null)
        {
            return c.timeStart;
        }
        else
        {
            return 0f;
        }
    }
    private float GetWrongNumFromScene9()
    {
        GameObject OB = GameObject.Find("Btn_1");
        OptionAG19 c = OB.GetComponent<OptionAG19>();
        if (c != null)
        {
            return c.wrong;
        }
        else
        {
            return 0f;
        }
    }
    private float GetCorrectFromScene9()
    {
        // 查找 Clock1 脚本并获取其 time 属性的值
        GameObject OA = GameObject.Find("Btn_3");
        OptionAG19 c = OA.GetComponent<OptionAG19>();
        if (c != null)
        {
            return c.correct;
        }
        else
        {
            return 0f;
        }
    }
    private float GetTimeFromScene10()
    {
        // 查 Clock1 脚本并获取其 time 属性的值
        TimeAG110 c = FindObjectOfType<TimeAG110>();
        if (c != null)
        {
            return c.timeStart;
        }
        else
        {
            return 0f;
        }
    }
    private float GetWrongNumFromScene10()
    {
        GameObject OB = GameObject.Find("Btn_1");
        OptionAG110 c = OB.GetComponent<OptionAG110>();
        if (c != null)
        {
            return c.wrong;
        }
        else
        {
            return 0f;
        }
    }
    private float GetCorrectFromScene10()
    {
        // 查找 Clock1 脚本并获取其 time 属性的值
        GameObject OA = GameObject.Find("Btn_2");
        OptionAG110 c = OA.GetComponent<OptionAG110>();
        if (c != null)
        {
            return c.correct;
        }
        else
        {
            return 0f;
        }
    }

    public static void DestroyInstance()
    {
        if (instance != null)
        {
            Destroy(instance.gameObject);
        }
    }
}