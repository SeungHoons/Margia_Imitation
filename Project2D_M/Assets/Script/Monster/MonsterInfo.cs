﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MonsterInfo : CharacterInfo
{
    [SerializeField]
    protected float m_fAttackDistance;
    [SerializeField]
    protected float m_fSpeed;
    [SerializeField]
    protected float m_fArmorPoint;
	[SerializeField]
	protected float m_fMaxArmorPoint;

	protected bool m_bNowArmorBreak =false;

	public float speed
	{
		get
		{
			return m_fSpeed;
		}
	}

    public struct MonsterCharInfo
    {
        public int level;
        public int maxHp;
        public int attack;
        public int defensive;
        public float attackDistance;
		public float speed;
    }

    public override int DamageCalculation(int _damage)
    {
        int returnDamage = _damage - defensive;
        if (returnDamage < 0)
            returnDamage = 0;
        return returnDamage;
    }

    public void SetInfo(MonsterCharInfo _charInfo)
    {
        level = _charInfo.level;
        maxHp = _charInfo.maxHp;
        hp = maxHp;
        attack = _charInfo.attack;
        defensive = _charInfo.defensive;
        m_fAttackDistance = _charInfo.attackDistance;
		m_fSpeed = _charInfo.speed;
    }

    public float GetAttackDistance()
    {
        return m_fAttackDistance;
    }

	public void ArmorDamage(int _damage)
	{
		if(!m_bNowArmorBreak)
			m_fArmorPoint -= _damage;
	}
	
}