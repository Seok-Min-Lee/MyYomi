using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text levelDisplayer;

    public Text expDisplayer;
    public Slider expSlider;

    public Text hpDisplayer;
    public Slider hpSlider;

    public Text cpDisplayer;
    public Slider cpSlider;

    /*public int level = DataController.Instance.GetLevel();
    public int currentExp = DataController.Instance.GetExp();
    public int fullExp = DataController.Instance.GetLevel() * 5;
    public int currentHp = DataController.Instance.GetHp();
    public int fullHp = DataController.Instance.GetLevel() * 10;*/
    void Start()
    {
        
    }

    void Update()
    {
        levelDisplayer.text = DataController.Instance.level + "";
        expDisplayer.text = DataController.Instance.currentExp + " / " + DataController.Instance.fullExp;
        hpDisplayer.text = DataController.Instance.currentHp + " / " + DataController.Instance.fullHp;
        cpDisplayer.text = DataController.Instance.currentCp + " / " + DataController.Instance.fullCp;

        expSlider.minValue = 0;
        expSlider.maxValue = DataController.Instance.fullExp;
        expSlider.value = DataController.Instance.currentExp;

        hpSlider.minValue = 0;
        hpSlider.maxValue = DataController.Instance.fullHp;
        hpSlider.value = DataController.Instance.currentHp;

        cpSlider.minValue = 0;
        cpSlider.maxValue = DataController.Instance.fullCp;
        cpSlider.value = DataController.Instance.currentCp;

    }
}
