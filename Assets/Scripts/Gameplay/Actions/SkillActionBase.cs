using CooldownAPI;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public abstract class SkillActionBase : AtomAction, IDisposable
{
    public float cooldownTime = 5f;

    protected Cooldown cooldown;

    private void OnValidate() => Dispose();

    public void Init()
    {
        cooldown = new Cooldown(cooldownTime);
    }

    public abstract void OnKeyDown();
    public abstract void OnKeyUp();
    public abstract void OnKeyHold();

    public virtual void Dispose()
    {
        // Reset cache
        cooldown = null;
    }
}
