using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    [SerializeField] private CoinCollector _coinCollector;

    private int _collectedCoins = 0;

    private void OnEnable()
    {
        _coinCollector.CoinCollected += OnCoinCollected;
    }

    private void OnDisable()
    {
        _coinCollector.CoinCollected -= OnCoinCollected;
    }

    private void OnCoinCollected(Coin coin)
    {
        _collectedCoins += coin.Value;
        Debug.Log("Собрано монет: " + _collectedCoins);
    }
}
