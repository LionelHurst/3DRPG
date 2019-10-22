using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TurnSystem : MonoBehaviour
{
    private List<Unit> units;

    // Start is called before the first frame update
    void Start()
    {
        units = new List<Unit>();
        GameObject[] playerUnits = GameObject.FindGameObjectsWithTag("Players");
        foreach(GameObject p in playerUnits)
        {
            Unit u = p.GetComponent<Unit>();
            units.Add(u);
        }

        GameObject[] enemyUnit = GameObject.FindGameObjectsWithTag("Enemies");
        foreach (GameObject e in enemyUnit)
        {
            Unit u = e.GetComponent<Unit>();
            units.Add(u);
        }

        units.Sort();
    }

    public void nextTurn()
    {
        Unit currentUnit = units[0];
        units.Remove(currentUnit);

        GameObject currentUnitObject = currentUnit.gameObject;
        units.Add(currentUnit);
        
        if (!currentUnit.IsDead()) {
            if (currentUnit.tag == "Players")
            {
                Debug.Log("Player unit acting");
            }
            else
            {
                Debug.Log("Enemy unit acting");
            }
        }
        else
        {
            this.nextTurn();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
