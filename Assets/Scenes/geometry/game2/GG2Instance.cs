using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GG2Instance : MonoBehaviour
{
    private static GG2Instance instance = null;
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

    public float FinalScoreFromYG2;
    public bool firstTime = true;

    private void Awake()
    {
        // ȷ��ֻ��һ�� SceneTransition ʵ��
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
        if (SceneManager.GetActiveScene().name == "JianYing1")
        {
            JCorrect1 = GetCorrectFromScene1();

            _time = GetTimeFromScene1();

            JWrong1 = GetWrongNumFromScene1();
            Debug.Log("JW1:" + JWrong1);
        }
        if (SceneManager.GetActiveScene().name == "JianYing2")
        {
            JCorrect2 = GetCorrectFromScene2();
            _time = GetTimeFromScene2();
            JWrong2 = GetWrongNumFromScene2();
        }
        if (SceneManager.GetActiveScene().name == "JianYing3")
        {
            JCorrect3 = GetCorrectFromScene3();
            _time = GetTimeFromScene3();
            JWrong3 = GetWrongNumFromScene3();
        }
        if (SceneManager.GetActiveScene().name == "JianYing4")
        {
            MCorrect1 = GetCorrectFromScene4();
            _time = GetTimeFromScene4();
            MWrong1 = GetWrongNumFromScene4();
        }
        if (SceneManager.GetActiveScene().name == "JianYing5")
        {
            MCorrect2 = GetCorrectFromScene5();
            _time = GetTimeFromScene5();
            MWrong2 = GetWrongNumFromScene5();
        }
        if (SceneManager.GetActiveScene().name == "JianYing6")
        {
            MCorrect3 = GetCorrectFromScene6();
            _time = GetTimeFromScene6();
            MWrong3 = GetWrongNumFromScene6();
        }
        if (SceneManager.GetActiveScene().name == "JianYing7")
        {
            HCorrect1 = GetCorrectFromScene7();
            _time = GetTimeFromScene7();
            HWrong1 = GetWrongNumFromScene7();
        }
        if (SceneManager.GetActiveScene().name == "JianYing8")
        {
            HCorrect2 = GetCorrectFromScene8();
            _time = GetTimeFromScene8();
            HWrong2 = GetWrongNumFromScene8();
        }
        if (SceneManager.GetActiveScene().name == "JianYing9")
        {
            HCorrect3 = GetCorrectFromScene9();
            _time = GetTimeFromScene9();
            HWrong3 = GetWrongNumFromScene9();
        }
        if (SceneManager.GetActiveScene().name == "JianYing10")
        {
            HCorrect4 = GetCorrectFromScene10();
            _time = GetTimeFromScene10();
            HWrong4 = GetWrongNumFromScene10();
        }
        if (SceneManager.GetActiveScene().name == "YGFinal")
        {
            ScoreForDigitWind =
          (
             Jcorrect * 10 - (JWR1 + JWR2 + JWR3) * 10
          + Mcorrect * 10 - (MWR1 + MWR2 + MWR3) * 10
          + Hcorrect * 10 - (HWR1 + HWR2 + HWR3 + HWR4) * 10
          ).ToString();

            FinalScoreFromYG2 = Jcorrect * 10 - (JWR1 + JWR2 + JWR3) * 10
        + Mcorrect * 10 - (MWR1 + MWR2 + MWR3) * 10
        + Hcorrect * 10 - (HWR1 + HWR2 + HWR3 + HWR4) * 10;

            firstTime = false;



        }
    }

    private float GetTimeFromScene1()
    {
        // �� Clock1 �ű�����ȡ�� time ���Ե�ֵ
        TimeYG1 c = FindObjectOfType<TimeYG1>();
        if (c != null)
        {
            return c.timeStart;
        }
        else
        {
            return 0f;
        }
    }
    private float GetCorrectFromScene1()
    {
        // ���� Clock1 �ű�����ȡ�� time ���Ե�ֵ
        GameObject OB = GameObject.Find("Btn_2");
        JianYing1 c = OB.GetComponent<JianYing1>();
        if (c != null)
        {
            return c.correct;
        }
        else
        {
            return 0f;
        }
    }
    private float GetWrongNumFromScene1()
    {
        GameObject OC = GameObject.Find("Btn_3");

        JianYing1 c = OC.GetComponent<JianYing1>();

        if (c != null)
        {
            return c.wrong;
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

    public static float FinalScoreForYG2
    {
        get { return instance != null ? instance.FinalScoreFromYG2 : 0f; }
    }
    public static bool FirstTime
    {
        get { return instance != null ? instance.firstTime : true; }
    }

    private float GetTimeFromScene2()
    {
        // �� Clock1 �ű�����ȡ�� time ���Ե�ֵ
        TimeYG2 c = FindObjectOfType<TimeYG2>();
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
        GameObject OC = GameObject.Find("Btn_2");

        JianYing2 c = OC.GetComponent<JianYing2>();

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
        // ���� Clock1 �ű�����ȡ�� time ���Ե�ֵ
        GameObject OA = GameObject.Find("Btn_1");
        JianYing2 c = OA.GetComponent<JianYing2>();
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
        // �� Clock1 �ű�����ȡ�� time ���Ե�ֵ
        TimeYG3 c = FindObjectOfType<TimeYG3>();
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
        GameObject OA = GameObject.Find("Btn_2");

        JianYing3 c = OA.GetComponent<JianYing3>();
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
        // ���� Clock1 �ű�����ȡ�� time ���Ե�ֵ
        GameObject OA = GameObject.Find("Btn_1");
        JianYing3 c = OA.GetComponent<JianYing3>();
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
        // �� Clock1 �ű�����ȡ�� time ���Ե�ֵ
        TimeYG4 c = FindObjectOfType<TimeYG4>();
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
        GameObject OC = GameObject.Find("Btn_2");

        JianYing4 c = OC.GetComponent<JianYing4>();
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
        // ���� Clock1 �ű�����ȡ�� time ���Ե�ֵ
        GameObject OC = GameObject.Find("Btn_3");
        JianYing4 c = OC.GetComponent<JianYing4>();
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
        // �� Clock1 �ű�����ȡ�� time ���Ե�ֵ
        TimeYG5 c = FindObjectOfType<TimeYG5>();
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
        GameObject OB = GameObject.Find("Btn_1");

        JianYing5 c = OB.GetComponent<JianYing5>();
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
        // ���� Clock1 �ű�����ȡ�� time ���Ե�ֵ
        GameObject OA = GameObject.Find("Btn_2");
        JianYing5 c = OA.GetComponent<JianYing5>();
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
        // �� Clock1 �ű�����ȡ�� time ���Ե�ֵ
        TimeYG6 c = FindObjectOfType<TimeYG6>();
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
        JianYing6 c = OB.GetComponent<JianYing6>();
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
        // ���� Clock1 �ű�����ȡ�� time ���Ե�ֵ
        GameObject OC = GameObject.Find("Btn_3");
        JianYing6 c = OC.GetComponent<JianYing6>();
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
        // �� Clock1 �ű�����ȡ�� time ���Ե�ֵ
        TimeYG7 c = FindObjectOfType<TimeYG7>();
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
        GameObject OB = GameObject.Find("Btn_3");

        JianYing7 c = OB.GetComponent<JianYing7>();
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
        // ���� Clock1 �ű�����ȡ�� time ���Ե�ֵ
        GameObject OA = GameObject.Find("Btn_1");
        JianYing7 c = OA.GetComponent<JianYing7>();
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
        // �� Clock1 �ű�����ȡ�� time ���Ե�ֵ
        TimeYG8 c = FindObjectOfType<TimeYG8>();
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
        GameObject OB = GameObject.Find("Btn_3");

        JianYing8 c = OB.GetComponent<JianYing8>();
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
        // ���� Clock1 �ű�����ȡ�� time ���Ե�ֵ
        GameObject OA = GameObject.Find("Btn_2");
        JianYing8 c = OA.GetComponent<JianYing8>();
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
        // �� Clock1 �ű�����ȡ�� time ���Ե�ֵ
        TimeYG9 c = FindObjectOfType<TimeYG9>();
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
        GameObject OE = GameObject.Find("Btn_1");

        JianYing9 c = OE.GetComponent<JianYing9>();
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
        // ���� Clock1 �ű�����ȡ�� time ���Ե�ֵ
        GameObject OB = GameObject.Find("Btn_2");
        JianYing9 c = OB.GetComponent<JianYing9>();
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
        // �� Clock1 �ű�����ȡ�� time ���Ե�ֵ
        TimeYG10 c = FindObjectOfType<TimeYG10>();
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
        GameObject OA = GameObject.Find("Btn_2");

        JianYing10 c = OA.GetComponent<JianYing10>();

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
        // ���� Clock1 �ű�����ȡ�� time ���Ե�ֵ
        GameObject OA = GameObject.Find("Btn_1");
        JianYing10 c = OA.GetComponent<JianYing10>();
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