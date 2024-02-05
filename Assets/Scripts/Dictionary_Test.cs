using System.Collections.Generic;
using UnityEngine;

public class Dictionary_Test : MonoBehaviour
{
    // Start is called before the first frame update
    Dictionary<string, int> BountyPirates = new Dictionary<string, int>()
    {
        {"Luffy",300000},
        {"Chooper",1000}
    };
    Dictionary<string, string> CelestialDragon = new Dictionary<string, string>()
    {
        {"Saturn", "EggHead" }
    };
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            UpdateBounty("Luffy", 600000);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            AddPirate("Kuma", 34000);
            Debug.Log("Pirate Count: " + BountyPirates.Count);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (CelestialDragon.ContainsKey("Saturn") && CelestialDragon.ContainsValue("EggHead"))
            {
                DeletePirate("Kuma");
            }
        }
    }
    void UpdateBounty(string namePirate, int newbounty)
    {
        BountyPirates[namePirate] = newbounty;
    }
    void AddPirate(string namePirate, int bounty)
    {
        BountyPirates.Add(namePirate, bounty);
    }
    void DeletePirate(string namePirate)
    {
        BountyPirates.Remove(namePirate);
    }
}
