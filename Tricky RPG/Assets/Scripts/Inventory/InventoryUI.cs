﻿using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public Transform itemsParent;
    public GameObject inventoryUI;

    private Inventory inventory;

    private InventorySlot[] slots;

    // Start is called before the first frame update
    void Start()
    {
        inventory = Inventory.instance;
        inventory.onItemChangedCalback += UpdateUI;

        slots = itemsParent.GetComponentsInChildren<InventorySlot>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            inventoryUI.SetActive(!inventoryUI.activeSelf);
        }
    }

    private void UpdateUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
    }
}
