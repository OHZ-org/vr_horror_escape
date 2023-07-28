using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class InputInven : MonoBehaviour
{
    public XRController controller = null;
    
    void Update()
    {
        CommonInput();
    }

    private void CommonInput()
    {
        // Y Button

        InputDevice device = controller.inputDevice;
        if (device.TryGetFeatureValue(CommonUsages.secondaryButton, out bool yButtonValue) && yButtonValue)
         {
            Debug.Log("############### Y´­¸² ######################");
            Inventory.inventoryActivated = !Inventory.inventoryActivated;
                if (Inventory.inventoryActivated)
                    OpenInventory();
                else
                    CloseInventory();
         }
    }

    private void OpenInventory()
    {
        Inventory.instance.gameObject.SetActive(true);
    }
    private void CloseInventory()
    {
        Inventory.instance.gameObject.SetActive(false);
    }
}
