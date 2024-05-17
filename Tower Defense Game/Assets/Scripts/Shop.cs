using UnityEngine;

public class Shop : MonoBehaviour
{
    private BuildManager buildManager;

    public TurretBlueprint standardTurret;
    public TurretBlueprint missileLauncher;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectStandardTurret()
    {
        if (buildManager == null)
        {
            Debug.LogError("BuildManager instance is not set.");
            return;
        }
        Debug.Log("Standard Turret Selected");
        buildManager.SelectTurretToBuild(standardTurret);
    }

    public void SelectMissileLauncher()
    {
        if (buildManager == null)
        {
            Debug.LogError("BuildManager instance is not set.");
            return;
        }
        Debug.Log("Missile Launcher Selected");
        buildManager.SelectTurretToBuild(missileLauncher);
    }
}