using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SetMedalNum : MonoBehaviour
{
    [SerializeField] private Text TutuMedal;
    [SerializeField] private Text TutuMedal1;

    [SerializeField] private Text CarrotMedal;
    [SerializeField] private Text CarrotMedal1;

    [SerializeField] private Text BearMedal;
    [SerializeField] private Text BearMedal1;

    [SerializeField] private Text FishMedal;
    [SerializeField] private Text FishMedal1;

    [SerializeField] private Text BirdMedal;
    [SerializeField] private Text BirdMedal1;

    [SerializeField] private Text FruitMedal;
    [SerializeField] private Text FruitMedal1;

    [SerializeField] private Text DeerMedal;
    [SerializeField] private Text DeerMedal1;

    [SerializeField] private Text FlowerMedal;
    [SerializeField] private Text FlowerMedal1;

    // Start is called before the first frame update
    void Start()
    {
        TutuMedal.text = GlobalStorage.instance.TutuMedal.ToString();
        TutuMedal1.text = GlobalStorage.instance.TutuMedal.ToString();

        CarrotMedal.text = GlobalStorage.instance.CarrotMedal.ToString();
        CarrotMedal1.text = GlobalStorage.instance.CarrotMedal.ToString();

        BearMedal.text = GlobalStorage.instance.BearMedal.ToString();
        BearMedal1.text = GlobalStorage.instance.BearMedal.ToString();

        FishMedal.text = GlobalStorage.instance.FishMedal.ToString();
        FishMedal1.text = GlobalStorage.instance.FishMedal.ToString();

        BirdMedal.text = GlobalStorage.instance.BirdMedal.ToString();
        BirdMedal1.text = GlobalStorage.instance.BirdMedal.ToString();

        FruitMedal.text = GlobalStorage.instance.FruitMedal.ToString();
        FruitMedal1.text = GlobalStorage.instance.FruitMedal.ToString();

        DeerMedal.text = GlobalStorage.instance.DeerMedal.ToString();
        DeerMedal1.text = GlobalStorage.instance.DeerMedal.ToString();

        FlowerMedal.text = GlobalStorage.instance.FlowerMedal.ToString();
        FlowerMedal1.text = GlobalStorage.instance.FlowerMedal.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
