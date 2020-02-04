using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimToAttackManager : MonoBehaviour
{
    public SkillManager SkillManager;
	public AttackCollider normalAttackCollider;
	private AnimFuntion m_animFuntion;

	private void Awake()
	{
		m_animFuntion = GetComponent<AnimFuntion>();
	}
	//애니메이션 이벤트 사용
	public void ColliderLifeCycleOn(float _time)
    {
		normalAttackCollider.ColliderLifeCycleOn(_time);
    }

	//애니메이션 이벤트 사용
	public void ColliderSkillLifeCycleOn(float _time)
	{
		SkillManager.ColliderLifeCycleOn(_time, m_animFuntion.GetCurrntAnimClipName());
	}

	//애니메이션 이벤트 사용
	public void ColliderSkillLifeCycleOnDraw(float _time)
	{
		SkillManager.ColliderLifeCycleOnDraw(_time, m_animFuntion.GetCurrntAnimClipName());
	}


	//애니메이션 이벤트 사용
	public void PlayAnim(string _animname)
    {
		SkillManager.PlayAnim(_animname);
    }
}
