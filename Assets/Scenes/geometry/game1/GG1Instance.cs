using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GG1Instance : MonoBehaviour
{
    public static GG1Instance instance = null;
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
    public float FinalScoreFromXG1;
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
        if (SceneManager.GetActiveScene().name == "TuXing1")
        {
            JCorrect1 = GetCorrectFromScene1();

            _time = GetTimeFromScene1();

            JWrong1 = GetWrongNumFromScene1();
            Debug.Log("JW1:" + JWrong1);
        }
        if (SceneManager.GetActiveScene().name == "TuXing2")
        {
            JCorrect2 = GetCorrectFromScene2();
            _time = GetTimeFromScene2();
            JWrong2 = GetWrongNumFromScene2();
        }
        if (SceneManager.GetActiveScene().name == "TuXing3")
        {
            JCorrect3 = GetCorrectFromScene3();
            _time = GetTimeFromScene3();
            JWrong3 = GetWrongNumFromScene3();
        }
        if (SceneManager.GetActiveScene().name == "TuXing4")
        {
            MCorrect1 = GetCorrectFromScene4();
            _time = GetTimeFromTG1Scene4();
            MWrong1 = GetWrongNumFromScene4();
        }
        if (SceneManager.GetActiveScene().name == "TuXing5")
        {
            MCorrect2 = GetCorrectFromScene5();
            _time = GetTimeFromTG1Scene5();
            MWrong2 = GetWrongNumFromScene5();
        }
        if (SceneManager.GetActiveScene().name == "TuXing6")
        {
            MCorrect3 = GetCorrectFromScene6();
            _time = GetTimeFromTG1Scene6();
            MWrong3 = GetWrongNumFromScene6();
        }
        if (SceneManager.GetActiveScene().name == "TuXing7")
        {
            HCorrect1 = GetCorrectFromScene7();
            _time = GetTimeFromTG1Scene7();
            HWrong1 = GetWrongNumFromScene7();
        }
        if (SceneManager.GetActiveScene().name == "TuXing8")
        {
            HCorrect2 = GetCorrectFromScene8();
            _time = GetTimeFromTG1Scene8();
            HWrong2 = GetWrongNumFromScene8();
        }
        if (SceneManager.GetActiveScene().name == "TuXing9")
        {
            HCorrect3 = GetCorrectFromScene9();
            _time = GetTimeFromTG1Scene9();
            HWrong3 = GetWrongNumFromScene9();
        }
        if (SceneManager.GetActiveScene().name == "TuXing10")
        {
            HCorrect4 = GetCorrectFromScene10();
            _time = GetTimeFromTG1Scene10();
            HWrong4 = GetWrongNumFromScene10();
        }
        if (SceneManager.GetActiveScene().name == "XGFinal")
        {
            ScoreForDigitWind =
         (
            Jcorrect * 10 - (JWR1 + JWR2 + JWR3) * 10
         + Mcorrect * 10 - (MWR1 + MWR2 + MWR3) * 10
         + Hcorrect * 10 - (HWR1 + HWR2 + HWR3 + HWR4) * 10
         ).ToString();
            FinalScoreFromXG1 = Jcorrect * 10 - (JWR1 + JWR2 + JWR3) * 10
        + Mcorrect * 10 - (MWR1 + MWR2 + MWR3) * 10
        + Hcorrect * 10 - (HWR1 + HWR2 + HWR3 + HWR4) * 10;

            firstTime = false;



        }
    }

    private float GetTimeFromScene1()
    {
        // 查第一关脚本并获取其 time 属性的值
        TimeTX1 c = FindObjectOfType<TimeTX1>();
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
        GameObject OA = GameObject.Find("BtnA");

        Tuxing1 c = OA.GetComponent<Tuxing1>();

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
        GameObject OB = GameObject.Find("BtnB");

        Tuxing1 c = OB.GetComponent<Tuxing1>();

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
    public static float FinalScoreForXG1
    {
        get { return instance != null ? instance.FinalScoreFromXG1 : 0f; }
    }
    public static bool FirstTime
    {
        get { return instance != null ? instance.firstTime : true; }
    }


    private float GetTimeFromScene2()
    {
        TimeTX2 s2 = FindObjectOfType<TimeTX2>();
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
        GameObject OA = GameObject.Find("BtnA");

        TuXing2 c = OA.GetComponent<TuXing2>();

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
        GameObject OD = GameObject.Find("BtnD");

        TuXing2 c = OD.GetComponent<TuXing2>();
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
        TimeTX3 s3 = FindObjectOfType<TimeTX3>();
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
        GameObject OA = GameObject.Find("BtnA");

        TuXing3 c = OA.GetComponent<TuXing3>();
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

        GameObject OB = GameObject.Find("BtnB");

        TuXing3 c = OB.GetComponent<TuXing3>();
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
        TimeTX4 s4 = FindObjectOfType<TimeTX4>();
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
        GameObject OA = GameObject.Find("BtnA");

        TuXing4 c = OA.GetComponent<TuXing4>();
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

        GameObject OC = GameObject.Find("BtnC");

        TuXing4 c = OC.GetComponent<TuXing4>();
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
        TimeTX5 s5 = FindObjectOfType<TimeTX5>();
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
        GameObject OA = GameObject.Find("BtnA");

        TuXing5 c = OA.GetComponent<TuXing5>();
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

        GameObject OD = GameObject.Find("BtnB");

        TuXing5 c = OD.GetComponent<TuXing5>();
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
        TimeTX6 s6 = FindObjectOfType<TimeTX6>();
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
        GameObject OA = GameObject.Find("BtnA");
        TuXing6 c = OA.GetComponent<TuXing6>();
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

        GameObject OD = GameObject.Find("BtnD");

        TuXing6 c = OD.GetComponent<TuXing6>();
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
        TimeTX7 s7 = FindObjectOfType<TimeTX7>();
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
        GameObject OB = GameObject.Find("BtnB");

        TuXing7 c = OB.GetComponent<TuXing7>();
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

        GameObject OA = GameObject.Find("BtnA");

        TuXing7 c = OA.GetComponent<TuXing7>();
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
        TimeTX8 s8 = FindObjectOfType<TimeTX8>();
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
        GameObject OB = GameObject.Find("BtnB");

        TuXing8 c = OB.GetComponent<TuXing8>();
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

        GameObject OA = GameObject.Find("BtnA");

        TuXing8 c = OA.GetComponent<TuXing8>();
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
        TimeTX9 s9 = FindObjectOfType<TimeTX9>();
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
        GameObject OB = GameObject.Find("BtnB");

        TuXing9 c = OB.GetComponent<TuXing9>();
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
        GameObject OA = GameObject.Find("BtnA");

        TuXing9 c = OA.GetComponent<TuXing9>();
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
        TimeTX10 s10 = FindObjectOfType<TimeTX10>();
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
        GameObject OA = GameObject.Find("BtnA");

        TuXing10 c = OA.GetComponent<TuXing10>();

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

        GameObject OC = GameObject.Find("BtnC");

        TuXing10 c = OC.GetComponent<TuXing10>();
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
