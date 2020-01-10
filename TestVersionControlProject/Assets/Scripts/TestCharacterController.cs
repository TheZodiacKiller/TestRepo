using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCharacterController : MonoBehaviour
{
    public string charName = "ZODIAC THE G";

    public int maxHealth = 1337;

    // Start is called before the first frame update
    void Start()
    {
        print(charName + " setup.");
    }

    // Update is called once per frame
    void Update()
    {
        print(charName + " got " + maxHealth + " HP");
    }
}
