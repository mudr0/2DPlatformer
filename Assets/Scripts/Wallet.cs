using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    [SerializeField] private Coin _coin;
    private int _collectedCoins = 0;

    public void AddCoin()
    {
        _collectedCoins += _coin.Value;
        Debug.Log("Собрано монет: " + _collectedCoins);
    }
}
