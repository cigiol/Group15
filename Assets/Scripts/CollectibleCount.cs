using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectibleCount : MonoBehaviour
{
    TMP_Text text;
    int count;
    void Awake()
    {
        text = GetComponent<TMP_Text>();
    }

    public void UpdateExp()
    {
        text.text = (++count).ToString();
    }

}
