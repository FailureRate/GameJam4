using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TMPFromDataInt : MonoBehaviour
{
    [Header("Format")]
    [SerializeField] private string format = "0000";
    [Header("Data")] 
    [SerializeField] private DataInt integer;
    [Header("References")]
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private Data data;

    // Start is called before the first frame update
    void Start()
    {
        integer = data.Int(integer);
    }

    // Update is called once per frame
    void Update()
    {
        text.SetText(integer.Value.ToString(format));
    }
}
