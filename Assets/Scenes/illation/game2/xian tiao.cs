using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class xiantiao : MonoBehaviour
{
    [SerializeField] string TatgetScene;
    public void OnBtnNewClick()
    {
        SceneManager.LoadScene(TatgetScene);
    }
}
