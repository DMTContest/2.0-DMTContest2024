using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TG1Instance : MonoBehaviour
{
    public static TG1Instance instance = null;
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
    public float FinalScoreFromIG1;
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
        // 从 SceneTime 脚本中获取 time 的值
        if (SceneManager.GetActiveScene().name == "Select1")
        {
            JCorrect1 = GetCorrectFromScene1();

            _time = GetTimeFromScene1();

            JWrong1 = GetWrongNumFromScene1();
            Debug.Log("JW1:" + JWrong1);
        }
        if (SceneManager.GetActiveScene().name == "Select2")
        {
            JCorrect2 = GetCorrectFromScene2();
            _time = GetTimeFromScene2();
            JWrong2 = GetWrongNumFromScene2();
        }
        if (SceneManager.GetActiveScene().name == "Select3")
        {
            JCorrect3 = GetCorrectFromScene3();
            _time = GetTimeFromScene3();
            JWrong3 = GetWrongNumFromScene3();
        }
        if (SceneManager.GetActiveScene().name == "Select4")
        {
            MCorrect1 = GetCorrectFromScene4();
            _time = GetTimeFromTG1Scene4();
            MWrong1 = GetWrongNumFromScene4();
        }
        if (SceneManager.GetActiveScene().name == "Select5")
        {
            MCorrect2 = GetCorrectFromScene5();
            _time = GetTimeFromTG1Scene5();
            MWrong2 = GetWrongNumFromScene5();
        }
        if (SceneManager.GetActiveScene().name == "Select6")
        {
            MCorrect3 = GetCorrectFromScene6();
            _time = GetTimeFromTG1Scene6();
            MWrong3 = GetWrongNumFromScene6();
        }
        if (SceneManager.GetActiveScene().name == "Select7")
        {
            HCorrect1 = GetCorrectFromScene7();
            _time = GetTimeFromTG1Scene7();
            HWrong1 = GetWrongNumFromScene7();
        }
        if (SceneManager.GetActiveScene().name == "Select8")
        {
            HCorrect2 = GetCorrectFromScene8();
            _time = GetTimeFromTG1Scene8();
            HWrong2 = GetWrongNumFromScene8();
        }
        if (SceneManager.GetActiveScene().name == "Select9")
        {
            HCorrect3 = GetCorrectFromScene9();
            _time = GetTimeFromTG1Scene9();
            HWrong3 = GetWrongNumFromScene9();
        }
        if (SceneManager.GetActiveScene().name == "Select10")
        {
            HCorrect4 = GetCorrectFromScene10();
            _time = GetTimeFromTG1Scene10();
            HWrong4 = GetWrongNumFromScene10();
        }
        if (SceneManager.GetActiveScene().name == "SGFinal")
        {
            ScoreForDigitWind =
         (
            Jcorrect * 10 - (JWR1 + JWR2 + JWR3) * 10
         + Mcorrect * 10 - (MWR1 + MWR2 + MWR3) * 10
         + Hcorrect * 10 - (HWR1 + HWR2 + HWR3 + HWR4) * 10
         ).ToString();
            FinalScoreFromIG1 = Jcorrect * 10 - (JWR1 + JWR2 + JWR3) * 10
        + Mcorrect * 10 - (MWR1 + MWR2 + MWR3) * 10
        + Hcorrect * 10 - (HWR1 + HWR2 + HWR3 + HWR4) * 10;

            firstTime = false;



        }
    }

    private float GetTimeFromScene1()
    {
        // 查第一关脚本并获取其 time 属性的值
        TimeIG1 c = FindObjectOfType<TimeIG1>();
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
        GameObject OB = GameObject.Find("Button-2");

        Select1 c = OB.GetComponent<Select1>();

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
        // 获得选项的脚本引用——
        GameObject OC = GameObject.Find("Button-3");


        Select1 c= OC.GetComponent<Select1>();

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
    public static float FinalScoreForIG1
    {
        get { return instance != null ? instance.FinalScoreFromIG1 : 0f; }
    }
    public static bool FirstTime
    {
        get { return instance != null ? instance.firstTime : true; }
    }


    private float GetTimeFromScene2()
    {
        TimeIG2 s2 = FindObjectOfType<TimeIG2>();
        if (s2 != null)
        {
            return s2.timeStart;
        }
        else
        {
            return 0f;
        }
    }
    private float GetWrongNumFromScene2()
    {
        GameObject OB = GameObject.Find("Button-2");

        Select2 c = OB.GetComponent<Select2>();
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
        GameObject OA = GameObject.Find("Button-1");

        Select2 c = OA.GetComponent<Select2>();
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
        TimeIG3 s3 = FindObjectOfType<TimeIG3>();
        if (s3 != null)
        {
            return s3.timeStart;
        }
        else
        {
            return 0f;
        }
    }
    private float GetWrongNumFromScene3()
    {
        GameObject OA = GameObject.Find("Button-1");

        Select3  c = OA.GetComponent<Select3>();
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

        GameObject OB = GameObject.Find("Button-2");

        Select3 c = OB.GetComponent<Select3>();
        if (c != null)
        {
            return c.correct;
        }
        else
        {
            return 0f;
        }
    }
    private float GetTimeFromTG1Scene4()
    {
        TimeIG4 s4 = FindObjectOfType<TimeIG4>();
        if (s4 != null)
        {
            return s4.timeStart;
        }
        else
        {
            return 0f;
        }
    }
    private float GetWrongNumFromScene4()
    {
        GameObject OA = GameObject.Find("Button-1");

        Select4 c = OA.GetComponent<Select4>();
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

        GameObject OB = GameObject.Find("Button-2");

        Select4 c = OB.GetComponent<Select4>();
        if (c != null)
        {
            return c.correct;
        }
        else
        {
            return 0f;
        }
    }
    private float GetTimeFromTG1Scene5()
    {
        TimeIG5 s5 = FindObjectOfType<TimeIG5>();
        if (s5 != null)
        {
            return s5.timeStart;
        }
        else
        {
            return 0f;
        }
    }
    private float GetWrongNumFromScene5()
    {
        GameObject OB = GameObject.Find("Button-2");

        Select5 c = OB.GetComponent<Select5>();
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

        GameObject OA = GameObject.Find("Button-1");

        Select5 c = OA.GetComponent<Select5>();
        if (c != null)
        {
            return c.correct;
        }
        else
        {
            return 0f;
        }
    }
    private float GetTimeFromTG1Scene6()
    {
        TimeIG6 s6 = FindObjectOfType<TimeIG6>();
        if (s6 != null)
        {
            return s6.timeStart;
        }
        else
        {
            return 0f;
        }
    }
    private float GetWrongNumFromScene6()
    {
        GameObject OA = GameObject.Find("Button-1");
        Select6 c = OA.GetComponent<Select6>();
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

        GameObject OB = GameObject.Find("Button-2");

        Select6 c = OB.GetComponent<Select6>();
        if (c != null)
        {
            return c.correct;
        }
        else
        {
            return 0f;
        }
    }
    private float GetTimeFromTG1Scene7()
    {
        TimeIG7 s7 = FindObjectOfType<TimeIG7>();
        if (s7 != null)
        {
            return s7.timeStart;
        }
        else
        {
            return 0f;
        }
    }
    private float GetWrongNumFromScene7()
    {
        GameObject OB = GameObject.Find("Button-2");

        Select7 c = OB.GetComponent<Select7>();
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

        GameObject OC = GameObject.Find("Button-3");

        Select7 c= OC.GetComponent<Select7>();
        if (c != null)
        {
            return c.correct;
        }
        else
        {
            return 0f;
        }
    }
    private float GetTimeFromTG1Scene8()
    {
        TimeIG8 s8 = FindObjectOfType<TimeIG8>();
        if (s8 != null)
        {
            return s8.timeStart;
        }
        else
        {
            return 0f;
        }
    }
    private float GetWrongNumFromScene8()
    {
        GameObject OA = GameObject.Find("Button-1");

        Select8 c = OA.GetComponent<Select8>();
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

        GameObject OB = GameObject.Find("Button-2");

        Select8 c = OB.GetComponent<Select8>();
        if (c != null)
        {
            return c.correct;
        }
        else
        {
            return 0f;
        }
    }
    private float GetTimeFromTG1Scene9()
    {
        TimeIG9 s9 = FindObjectOfType<TimeIG9>();
        if (s9 != null)
        {
            return s9.timeStart;
        }
        else
        {
            return 0f;
        }
    }
    private float GetWrongNumFromScene9()
    {
        GameObject OB = GameObject.Find("Button-2");

        Select9 c = OB.GetComponent<Select9>();
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
        GameObject OC = GameObject.Find("Button-3");

        Select9 c = OC.GetComponent<Select9>();
        if (c != null)
        {
            return c.correct;
        }
        else
        {
            return 0f;
        }
    }
    private float GetTimeFromTG1Scene10()
    {
        TimeIG10 s10 = FindObjectOfType<TimeIG10>();
        if (s10 != null)
        {
            return s10.timeStart;
        }
        else
        {
            return 0f;
        }
    }
    private float GetWrongNumFromScene10()
    {
        GameObject OA = GameObject.Find("Button-1");

        Select10 c = OA.GetComponent<Select10>();

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

        GameObject OB = GameObject.Find("Button-2");

        Select10 c = OB.GetComponent<Select10>();
        if (c != null)
        {
            return c.correct;
        }
        else
        {
            return 0f;
        }
    }
}