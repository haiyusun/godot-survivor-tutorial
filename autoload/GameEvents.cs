using Godot;
using System;
using Godot.Collections;

public partial class GameEvents : Node {

    [Signal]
    public delegate void ExperienceVialCollectedEventHandler(float exNum);
    
    [Signal]
    public delegate void AbilityUpgradeAddedEventHandler(AbilityUpgrade abilityUpgrade, Dictionary<string, UpgradeDictValue> currentUpgrades);
    
    public void EmitExperienceVialCollected(float ex) {
        EmitSignal(SignalName.ExperienceVialCollected, ex);
    }
    
    public void EmitAbilityUpgradeAdded(AbilityUpgrade abilityUpgrade, Dictionary<string, UpgradeDictValue> currentUpgrades) {
        EmitSignal(SignalName.AbilityUpgradeAdded, abilityUpgrade, currentUpgrades);
    }
    
}
