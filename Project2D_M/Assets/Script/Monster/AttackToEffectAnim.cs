using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AttackToEffectAnim : MonoBehaviour
{
    public SkillManager skillManager;

    //애니메이션 이벤트 사용
    public void PlayAnimToSkill(string _animname)
    {
		skillManager.PlayAnim(_animname);
    }
}
