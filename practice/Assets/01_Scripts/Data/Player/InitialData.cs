﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InitialData : MonoBehaviour
{

    public float GamePlayingSpeed;

    public int StartAttack;
    public int StartHealth;
    public float AttackSpeed;
    public float AttackRange;

    public InitialData()
    {
        LoadData();
    }

    private void LoadData()
    {
        GamePlayingSpeed = DataTable.시작값.시작값List[0].게임진행속도;
        StartAttack = DataTable.시작값.시작값List[0].기본_공격력;
        StartHealth = DataTable.시작값.시작값List[0].기본_체력;
        AttackSpeed = DataTable.시작값.시작값List[0].기본_공속;
        AttackRange = DataTable.시작값.시작값List[0].기본_사거리;
    }
}
