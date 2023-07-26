using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;


public class InventoryUI : MonoBehaviour
{
    private InputAction inventoryAction;
    Inventory inven;
    public GameObject inventoryPanel;
    bool activeInventory = false;

    public Slot[] slots;
    public Transform slotHolder;
    private void Start()
    {
        inven = Inventory.instance;
        slots = slotHolder.GetComponentsInChildren<Slot>();
        inven.onSlotCountChange += SlotChange;
        inventoryPanel.SetActive(activeInventory);
    }

    private void SlotChange(int val)
    {
        for(int i = 0; i < slots.Length; i++)
        {
            if (i < inven.SlotCnt)
                slots[i].GetComponent<Button>().interactable = true;
            else
                slots[i].GetComponent<Button>().interactable = false;
        }
    }

    private void Awake()
    {
        inventoryAction = new InputAction(binding: "<Gamepad>/buttonSouth");
    }
    private void OnEnable()
    {
        inventoryAction.Enable();
    }

    private void OnDisable()
    {
        inventoryAction.Disable();
    }

    private void Update()
    {
        if (inventoryAction.triggered)
        {
            activeInventory = !activeInventory;
            inventoryPanel.SetActive(activeInventory);
        }
    }

    public void AddSlot()
    {
        inven.SlotCnt++;
    }
}