using UnityEngine;

[CreateAssetMenu(fileName = "New Equipment", menuName = "Inventory/Equipment")]
public class Equipment : Item
{
    public EquipmentSlot equipSlot;
    public SkinnedMeshRenderer mesh;

    public int armorModifier;
    public int damageModifier;

    public EquipmentMeshRegion[] coveredMeshRegions;

    public override void Use()
    {
        base.Use();
        EquipmentManager.instance.Equip(this);
        RemoveFromInventory();
    }
}

public enum EquipmentSlot
{
    Head,
    Chest,
    Legs,
    Weapon,
    Shield,
    Feet
}

public enum EquipmentMeshRegion
{
    Legs,
    Arms,
    Torso
}
