using UnityEngine;
using UnityEngine.InputSystem;
namespace LP.SpawnOnClickNewInput
{
public class SpawnOnClick : MonoBehaviour
{
    [SerializeField]GameObject spawnPrefab=null;
    [SerializeField]SoldierType soldierType;
    private Camera cam=null;
    private void Start() 
    {
        cam=Camera.main;
    }
    private void Update()
    {
        SpawnAtMousePos();
    }
    private void SpawnAtMousePos()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            Ray ray=cam.ScreenPointToRay(Mouse.current.position.ReadValue());
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit))
            {
                if(hit.transform.tag=="Ground")
                Instantiate(spawnPrefab,new Vector3(hit.point.x,soldierType.soldierScale.y,hit.point.z),Quaternion.identity);
            }
        }
    }
}
}

