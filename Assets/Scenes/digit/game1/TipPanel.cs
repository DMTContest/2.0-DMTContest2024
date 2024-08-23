using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipPanel : MonoBehaviour
{
    [SerializeField] public GameObject Panel1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenPanel1()
    {
        Panel1.SetActive(true);
    }
}
