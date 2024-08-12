using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DG2Instance : MonoBehaviour
{
    private static DG2Instance instance = null;
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
        if(SceneManager.GetActiveScene().name == "DG2"){
            JCorrect1= GetCorrectFromScene1();

            _time = GetTimeFromScene1();
            
            JWrong1 = 0 ;
        }
        if(SceneManager.GetActiveScene().name == "DG22")
        {
            JCorrect2= GetCorrectFromScene2();
            _time = GetTimeFromScene2();
            
            JWrong2 = 0;
 
        }if(SceneManager.GetActiveScene().name == "DG23")
        {
            JCorrect3= GetCorrectFromScene2();

            _time = GetTimeFromScene3();
            
            JWrong3 =GetWrongNumFromScene3();
 
        }        
        if(SceneManager.GetActiveScene().name == "DG24"){
            MCorrect1= GetCorrectFromScene4();

            _time = GetTimeFromScene4();
            
            MWrong1 =GetWrongNumFromScene4();
        }
        if(SceneManager.GetActiveScene().name == "DG25")
        {
            MCorrect2= GetCorrectFromScene5();
            _time = GetTimeFromScene5();
            
            MWrong2 =GetWrongNumFromScene5();
 
        }if(SceneManager.GetActiveScene().name == "DG26")
        {
            MCorrect3= GetCorrectFromScene6();

            _time = GetTimeFromScene6();
            
            MWrong3 =GetWrongNumFromScene6();
 
        }        
        if(SceneManager.GetActiveScene().name == "DG27"){
            HCorrect1= GetCorrectFromScene7();

            _time = GetTimeFromScene7();
            
            HWrong1 =GetWrongNumFromScene7();
        }
        if(SceneManager.GetActiveScene().name == "DG28")
        {
            HCorrect2= GetCorrectFromScene8();
            _time = GetTimeFromScene8();
            
            HWrong2 =GetWrongNumFromScene8();
 
        }if(SceneManager.GetActiveScene().name == "DG29")
        {
            HCorrect3= GetCorrectFromScene9();

            _time = GetTimeFromScene9();
            
            HWrong3 =GetWrongNumFromScene9();
 
        }        
        if(SceneManager.GetActiveScene().name == "DG210"){
            HCorrect4= GetCorrectFromScene10();

            _time = GetTimeFromScene10();
            
            HWrong4 =GetWrongNumFromScene10();
        }
        if (SceneManager.GetActiveScene().name == "DG2Final")
        {
           ScoreForDigitWind = 
        (
           Jcorrect*10 - (JWR1 +JWR2 +JWR3)*10
        +  Mcorrect*10 - (MWR1 +MWR2 +MWR3)*10
        +  Hcorrect*10 - (HWR1 +HWR2 +HWR3 + HWR4)*10
        ).ToString();
        
        

        }
    }

    private float GetTimeFromScene1()
    {
        // 查 Clock1 脚本并获取其 time 属性的值
       TimeDG2 c = FindObjectOfType<TimeDG2>();
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
        // 查找 Clock1 脚本并获取其 time 属性的值
       Option c = FindObjectOfType<Option>();
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
        get { return instance != null ? instance.JCorrect1+instance.JCorrect2+instance.JCorrect3 : 0f; }
    }
            public static float Mcorrect
    {
        get { return instance != null ? instance.MCorrect1+instance.MCorrect2+instance.MCorrect3 : 0f; }
    }
            public static float Hcorrect
    {
        get { return instance != null ? instance.HCorrect1+instance.HCorrect2+instance.HCorrect3+instance.HCorrect4 : 0f; }
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

    private float GetTimeFromScene2()
    {
        // 查 Clock1 脚本并获取其 time 属性的值
       TimeDG22 c = FindObjectOfType<TimeDG22>();
        if (c != null)
    {
        return c.timeStart;
    }
    else
    {
        return 0f;
    }
    }
        private float GetCorrectFromScene2()
    {
        // 查找 Clock1 脚本并获取其 time 属性的值
       Option2 c = FindObjectOfType<Option2>();
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
       TimeMG3 c = FindObjectOfType<TimeMG3>();
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
       GameManager3 c = FindObjectOfType<GameManager3>();
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
       GameManager3 c = FindObjectOfType<GameManager3>();
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
       TimeMG4 c = FindObjectOfType<TimeMG4>();
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
       GameManager4 c = FindObjectOfType<GameManager4>();
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
       GameManager4 c = FindObjectOfType<GameManager4>();
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
       TimeMG5 c = FindObjectOfType<TimeMG5>();
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
       GameManager5 c = FindObjectOfType<GameManager5>();
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
       GameManager5 c = FindObjectOfType<GameManager5>();
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
       TimeMG6 c = FindObjectOfType<TimeMG6>();
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
       GameManager6 c = FindObjectOfType<GameManager6>();
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
       GameManager6 c = FindObjectOfType<GameManager6>();
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
       TimeMG7 c = FindObjectOfType<TimeMG7>();
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
       GameManager7 c = FindObjectOfType<GameManager7>();
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
       GameManager7 c = FindObjectOfType<GameManager7>();
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
       TimeMG8 c = FindObjectOfType<TimeMG8>();
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
       GameManager8 c = FindObjectOfType<GameManager8>();
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
       GameManager8 c = FindObjectOfType<GameManager8>();
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
       TimeMG9 c = FindObjectOfType<TimeMG9>();
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
       GameManager9 c = FindObjectOfType<GameManager9>();
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
       GameManager9 c = FindObjectOfType<GameManager9>();
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
       TimeMG10 c = FindObjectOfType<TimeMG10>();
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
       GameManager10 c = FindObjectOfType<GameManager10>();
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
       GameManager10 c = FindObjectOfType<GameManager10>();
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