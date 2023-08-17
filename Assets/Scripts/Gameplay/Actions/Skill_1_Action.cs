using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using CooldownAPI;

[CreateAssetMenu(fileName = "Skill 1", menuName = "BomBerMan/Actions/Skills/Skill 1 Action")]
public class Skill_1_Action : SkillActionBase
{
    public override void OnKeyDown()
    {
        if (cooldown.IsActive)
            return;

        cooldown.Activate();
        Debug.Log($"{this.GetType().Name} OnKeyDown");
    }

    public override void OnKeyHold()
    {
        Debug.Log($"{this.GetType().Name} OnKeyHold");
    }

    public override void OnKeyUp()
    {
        Debug.Log($"{this.GetType().Name} OnKeyUp");
    }
}
