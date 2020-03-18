using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    [SerializeField] private Coin _coin;
    private int _collectedCoins = 0;
    private Coin[] _coins;

    private void OnEnable()
    {
        _coins = GetComponentsInChildren<Coin>();
        foreach (var coin in _coins)
        {
            coin.Collected += OnCoinCollected;
        }
    }
    private void OnDisable()
    {
        foreach (var coin in _coins)
        {
            coin.Collected -= OnCoinCollected;
        }
    }

    private void OnCoinCollected()
    {
        _collectedCoins += _coin.Value;
        Debug.Log("Собрано монет: " + _collectedCoins);
    }
}
