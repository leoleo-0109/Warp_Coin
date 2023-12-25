using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    [SerializeField] private int max_coin = 5;
    private int now_coin = 0;

    [SerializeField] private ScenePass end;

    private void Update()
    {
        if (now_coin >= max_coin)
        {
            end.goend();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            now_coin++;
            Destroy(other.gameObject);
        }
    }

    public int Getcoin()
    {
        return now_coin;
    }

    public int Maxcoin()
    {
        return max_coin;
    }
}
