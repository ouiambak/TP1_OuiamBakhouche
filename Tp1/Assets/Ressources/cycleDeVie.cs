using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using TMPro;
using UnityEngine;

public class cycleDeVie : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    private int vie = 10;
    // Start is called before the first frame update
    public void CycleDevie() {
        vie--;
        _text.text = vie.ToString();
    }
}
