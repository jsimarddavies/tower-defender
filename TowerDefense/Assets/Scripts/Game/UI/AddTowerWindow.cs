using System;
using UnityEngine;

public class AddTowerWindow : MonoBehaviour
{
    // Reference to tower slot that needs a new tower when a tower is chosen
    public GameObject towerSlotToAddTowerTo;

    public void AddTower(string towerTypeAsString)
    {
        // Unfortunately Unity doesn't allow passing enums in event triggers so we pass a string and convert it to the enum instead
        TowerType type = (TowerType)Enum.Parse(typeof(TowerType), towerTypeAsString, true);

        if (TowerManager.Instance.GetTowerPrice(type) <= GameManager.Instance.gold)
        {
            GameManager.Instance.gold -= TowerManager.Instance.GetTowerPrice(type);

            TowerManager.Instance.CreateNewTower(towerSlotToAddTowerTo, type);
            gameObject.SetActive(false);
        }
    }
}
