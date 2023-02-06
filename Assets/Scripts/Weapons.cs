using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapons : MonoBehaviour
{
    // Start is called before the first frame update
    public abstract float useWeapon();
    public abstract void secureWeapon();
    public abstract string weaponName();

}
