﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _value;

    public int Value
    {
        get
        {
            return _value;
        }
        private set
        {
            _value = value;
        }
    }
}
