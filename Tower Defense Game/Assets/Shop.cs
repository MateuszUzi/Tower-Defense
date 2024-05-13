using UnityEngine;
public class Shop : MonoBehaviour
{
    public GameObject standardTurretPrefab;
    public GameObject anotherTurretPrefab;

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void PurchaseStandardTurret()
    {
        if (buildManager != null && standardTurretPrefab != null)
        {
            Debug.Log("Standard TurretSelected");
            buildManager.SetTurretToBuild(standardTurretPrefab);
        }
        else
        {
            Debug.LogError("Build Manager or Standard Turret Prefab is not assigned!");
        }
    }

    public void PurchaseMissleLauncher()
    {
        if (buildManager != null && anotherTurretPrefab != null)
        {
            Debug.Log("Missle Launcher Selected");
            buildManager.SetTurretToBuild(anotherTurretPrefab);
        }

    }
}
