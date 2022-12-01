using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaBar : MonoBehaviour
{
    public Slider manaSlider;
    
    private void Start() {
        manaSlider = GetComponent<Slider>();
    }

    public void setMaxMana(int maxMana) {
        manaSlider.maxValue = maxMana;
        manaSlider.value = maxMana;
    }

    public void setMana(int mana) {
        manaSlider.value = mana;
    }
}
