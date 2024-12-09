using System;
using System.Collections.Generic;
using UnityEngine;

public interface ISkillInterface {

    float GetEXP();
    void IncreaseEXP(float increase);
    string GetName();
    int GetLevel();
    bool IsElementalSkill();
    Dictionary<string, float> GetStats();
}