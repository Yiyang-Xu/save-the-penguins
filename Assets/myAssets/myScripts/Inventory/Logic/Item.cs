using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public ItemName itemName;

    public void ItemClicked()
    {
        //Add the item to the package
        ItemManager.Instance.AddItem(itemName);
        this.gameObject.SetActive(false);
    }
}
