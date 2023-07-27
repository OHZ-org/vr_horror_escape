using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;
    public static bool inventoryActivated = false;

    [SerializeField]
    private GameObject go_InventoryBase;
    [SerializeField]
    private GameObject go_SlotsParent;

    private Slot[] slots;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject); // 인벤토리 오브젝트를 씬이 변경되더라도 파괴되지 않도록 설정
    }


    void Start()
    {
        slots = go_SlotsParent.GetComponentsInChildren<Slot>();
    }

    void Update()
    {
        TryOpenInventory();
    }
    private void TryOpenInventory()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            inventoryActivated = !inventoryActivated;
            if (inventoryActivated)
                OpenInventory();
            else
                CloseInventory();
        }
    }

    private void OpenInventory()
    {
        go_InventoryBase.SetActive(true);
    }
    private void CloseInventory()
    {
        go_InventoryBase.SetActive(false);
    }

    public void AcquireItem(Item1 _item)
    {
        for(int i = 0; i < slots.Length; i++)
        {
            if(slots[i].item.itemName == null)
            {
                slots[i].AddItem(_item);
                return;
            }
        }
    }
}
