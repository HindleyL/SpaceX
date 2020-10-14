using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int GlobalMoney;
    public Text Money;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("addmoney", 2, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addmoney()
    {
        Money.text = GlobalMoney.ToString();
    }
}
