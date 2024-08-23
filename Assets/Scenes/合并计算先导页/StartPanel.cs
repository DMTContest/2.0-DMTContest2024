using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPanel : MonoBehaviour
{
    [SerializeField] public GameObject Panel1;
    [SerializeField] public GameObject Panel2;
    [SerializeField] public GameObject Panel3;
    [SerializeField] public GameObject Panel4;

    // Start is called before the first frame update
    void Start()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        Panel4.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
