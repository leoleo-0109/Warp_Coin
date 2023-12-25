using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIController : MonoBehaviour
{
    [SerializeField] private Text coin;
    [SerializeField] private Hit player;
    [SerializeField] private Text timecount;

    private float time = 0;
    private int minutes = 0;


    void Start()
    {
        coin.text = player.Getcoin() + "/" + player.Maxcoin();
        timecount.text = "00:00";
    }

    void Update()
    {
        coin.text = "Coin:" + player.Getcoin() + "/" + player.Maxcoin(); //コインの獲得数の表示

        timecount.text = "Time:" + minutes.ToString("00") + ":" + ((int)time).ToString("00"); //時間の表示

        if (time >= 60)
        {
            minutes++;
            time = 0;
        }
        else
        {
            time += Time.deltaTime;
        }
    }
}
