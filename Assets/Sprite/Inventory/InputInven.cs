using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class InputInven : MonoBehaviour
{
    public XRController controller = null;
    private GameObject _camera;

    private void Awake()
    {
        _camera = GetComponent<XRRig>().cameraGameObject;
    }

    // Update is called once per frame
    void Update()
    {
        CommonInput();
    }

    private void CommonInput()
    {
        // Y Button
        if (controller.inputDevice.TryGetFeatureValue(CommonUsages.secondaryButton, out bool secondary))
        {
            if (secondary)
            {
                Inventory.inventoryActivated = !Inventory.inventoryActivated;
                if (Inventory.inventoryActivated)
                    OpenInventory();
                else
                    CloseInventory();
            }
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
